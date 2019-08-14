using Area.Models;
using Area.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.adminproject.Controllers
{
    [AllowAnonymous]
    public class RegisterTempController : Controller
    {
        KarateSchoolEntities db = new KarateSchoolEntities();

        // GET: RegisterTemp
        public ActionResult Index()
        {

            CreateVM model = new CreateVM()
            {
                Groups = db.Groups.ToList(),
                Student = null
                
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult RegisterTE()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterTE(Student Student)
        {
            db.Students.Add(Student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}