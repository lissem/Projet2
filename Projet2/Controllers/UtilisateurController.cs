using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Projet2.Models;


namespace Projet2.Controllers
{
    public class UtilisateurController : Controller
    {
        pandamidbEntities db = new pandamidbEntities();
    
       
        public ActionResult Index()
        {
         return View();
        }
        public ActionResult Utilisateur()
        {
           
               


            
            try
            {
                ViewBag.Title = "Utilisateur";
                ViewBag.listeUtilisateur = db.utilisateur.ToList();
                return View();
            }
            catch(Exception e)
            {
                return HttpNotFound();
            }
           
        }
        [HttpPost]
        public ActionResult AjoutUtilisateur(utilisateur utilisateur)
        {
            try
            {
              if(ModelState.IsValid)
                {
                    ViewBag.listeUtilisateur = db.utilisateur.ToList();
                    utilisateur.date_inscription = DateTime.Now;
                    db.utilisateur.Add(utilisateur);
                    db.SaveChanges();
                }
                
                return Utilisateur();
            }
            catch(Exception e)
            {
                return HttpNotFound();
            }
         
            
        }
           

    }
}