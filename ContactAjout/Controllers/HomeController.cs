using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactAjout.Models;

namespace ContactAjout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modifiez ce modèle pour dynamiser votre application ASP.NET MVC.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Votre page de description d’application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Votre page de contact.";

            return View();
        }
        [HttpGet]
        public ActionResult AjoutContact()
        {
            ViewBag.Message = "Votre page d'ajout de contact.";

            return View();


        }

        [HttpPost]
        public ActionResult AjoutContact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                NouveauContact(model.Nom, model.Email, model.Commentaire);
                TempData["attention"] = "Votre requête a été envoyée.";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private void NouveauContact(string Nom, string Email, string Commentaire)
        {
            //rien encore ici
        }
    }
}
