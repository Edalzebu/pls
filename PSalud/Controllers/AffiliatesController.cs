using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using PSalud.DataAccess.NHibernate;
using PSalud.DataAccess.Repositories;
using PSalud.Entities.Domains.Generals;
using PSalud.Entities.Domains.Pacientes;
using PSalud.Entities.Domains.Profiles;
using PSalud.Models.Affiliates;

namespace PSalud.Controllers
{
    public class AffiliatesController : Controller
    {
        protected static UnitOfWork UoW;
        
        private static Repository Repository()
        {
            UoW = new UnitOfWork(new NHibernateHelper(ConfigurationManager.ConnectionStrings["PSaludConnectionString"].ConnectionString).SessionFactory);
            var repository = new Repository(UoW.Session);
            return repository;
        }

        public ActionResult NewAffiliate()
        {
            var modelo = new AffiliatesModel();
            modelo.Ciudad = Repository().Query<Ciudades>().ToList();
            modelo.TipoPaciente = Repository().Query<TipoPacientes>().ToList();
            

            return PartialView(new AffiliatesModel());
        }
        
        [HttpPost]
        public ActionResult NewAffiliate(AffiliatesModel model)
        {
            var repo = Repository();
            var newCiudad = repo.First<Ciudades>(x => x.Id_Ciudad == 1);
            var newTipoPaciente = repo.First<TipoPacientes>(x => x.Id_TipoPaciente == 1);
            var newPerson = Mapper.Map<AffiliatesModel, Personas>(model);
            newPerson.Id_Ciudad = newCiudad;
            repo.Add(newPerson);
            var afiliado = Mapper.Map<AffiliatesModel, Pacientes>(model);
            afiliado.AddPerson(newPerson);
            afiliado.AddTipoPaciente(newTipoPaciente);
            repo.Add(afiliado);
            UoW.Commit();
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public ActionResult ListAffiliates()
        {
            var repo = Repository();
            var listaPacientes = repo.GetAll<Pacientes>();
            var listamodelos = new List<ListAffiliatesModel>();
            foreach (var paciente in listaPacientes)
            {
                //var modelo = Mapper.Map<Pacientes, ListAffiliatesModel>(paciente);
                var modelo = new ListAffiliatesModel();
                modelo.Nombres = paciente.Persona.Nombres;
                modelo.PrimerApellido = paciente.Persona.Primer_Apellido;
                modelo.SegundoApellido = paciente.Persona.Segundo_Apellido;
                listamodelos.Add(modelo);
            }
            return PartialView(listamodelos);
        }
           
        public void GetCiudades()
        {
        }
    }
}

