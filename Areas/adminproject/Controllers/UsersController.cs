using Area.Models;
using Area.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.adminproject.Controllers
{
    public class UsersController : Controller
    {
        KarateSchoolEntities db = new KarateSchoolEntities();
        // GET: adminproject/Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            CreateVM model = new CreateVM()
            {
                Groups = db.Groups.ToList(),
                Student = null,
                Action="Create"
            };
            return View(model);
        }

        public ActionResult CrtTeacher()
        {
            CreateT model = new CreateT()
            {
                Positions = db.Positions.ToList(),
                Teacher = null,
                Action = "CreateTeacher"

            };
            return View(model);
        }

        public ActionResult CrtEmployee()
        {
            CreateE model = new CreateE()
            {
                Positions = db.Positions.ToList(),
                Employee = null,
                Action = "CreateEmployee"

            };
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            CreateVM model = new CreateVM()
            {
                Groups = db.Groups.ToList(),
                Student = db.Students.FirstOrDefault(s=>s.Id==id),
                Action = "Edit"
            };
            return View("Create",model);
        }

        public ActionResult EditTeacher(int id)
        {
            CreateT model = new CreateT()
            {
                Positions = db.Positions.ToList(),
                Teacher =db.Teachers.FirstOrDefault(t=>t.Id==id),
                Action ="EditTeacher"
            };
            return View("CrtTeacher",model);
        }


        public ActionResult EditEmpl(int id)
        {
            CreateE model = new CreateE()
            {
                Positions = db.Positions.ToList(),
                Employee = db.Employees.FirstOrDefault(t => t.Id == id),
                Action = "EditEmpl"
            };
            return View("CrtEmployee", model);
        }

    }
}