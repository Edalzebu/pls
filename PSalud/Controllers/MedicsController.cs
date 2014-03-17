using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using PSalud.DataAccess.NHibernate;
using PSalud.DataAccess.Repositories;
using PSalud.Entities.Domains.Clinicas;
using PSalud.Entities.Domains.Generals;
using PSalud.Entities.Domains.Medicos;
using PSalud.Entities.Domains.Pacientes;
using PSalud.Entities.Domains.Profiles;
using PSalud.Models.Medics;

namespace PSalud.Controllers
{
    public class MedicsController : Controller
    {
        protected static UnitOfWork UoW;
        private static Repository Repository()
        {
            UoW = new UnitOfWork(new NHibernateHelper(ConfigurationManager.ConnectionStrings["PSaludConnectionString"].ConnectionString).SessionFactory);
            var repository = new Repository(UoW.Session);
            return repository;
        }

        public ActionResult NewMedic()
        {
            var modelo = new MedicsModel();
            modelo.Ciudad= Repository().Query<Ciudades>().ToList();
            modelo.Especialidades = Repository().Query<Especialidades>().ToList();
            modelo.Clinicas = Repository().Query<Clinicas>().ToList();
           return PartialView(modelo);
        }

        [HttpPost]
        public ActionResult NewMedic(MedicsModel model)
        {
            var repo = Repository();
            var newCiudad = repo.First<Ciudades>(x => x.Id_Ciudad == 1);
            var newTipoPaciente = repo.First<TipoPacientes>(x => x.Id_TipoPaciente == 1);

            var newPerson = Mapper.Map<MedicsModel, Personas>(model);
            newPerson.Id_Ciudad = newCiudad;
            //Save person object
            repo.Add(newPerson);

            var newEspecialidad = repo.First<Especialidades>(x => x.Id_Especialidad == 1);
            var newClinica = repo.First<Clinicas>(x => x.Id_Clinica == 1);

            var newMedic = new Medicos
            {
                Id_Especialidad =  newEspecialidad,
                Id_Clinica = newClinica,
                Id_Persona = newPerson
            };
            repo.Add(newMedic);
            UoW.Commit();
            return RedirectToAction("Index", "Home");
        }
    }
}
