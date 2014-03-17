using System.Web.Mvc;

using PSalud.DataAccess.NHibernate;
using System.Configuration;
using PSalud.DataAccess.Repositories;
using PSalud.Models.Security;
using PSalud.Entities.Domains.Security;

namespace PSalud.Controllers
{
    public class SecurityController : Controller
    {
        protected static UnitOfWork UoW;
        private static Repository Repository()
        {
            UoW = new UnitOfWork(new NHibernateHelper(ConfigurationManager.ConnectionStrings["PSaludConnectionString"].ConnectionString).SessionFactory);
            var repository = new Repository(UoW.Session);
            return repository;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var repo = Repository();
            var currentUser = repo.First<Usuarios>(x =>x.Nombre_Usuario == model.UserName && x.Contrasenia == model.Password);
            if (currentUser != null)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }

    }
}
