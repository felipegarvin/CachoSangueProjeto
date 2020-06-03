using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CachoSangueProjeto.DAO;

namespace CachoSangueProjeto.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Inicio()
        {
            int i = DAO.Facade.RetornarPadAcess();

            if(i == 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("About");
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}