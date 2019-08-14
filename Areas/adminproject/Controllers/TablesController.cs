using Area.Models;
using Area.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.adminproject.Controllers
{

    public class TablesController : Controller
    {
        // GET: adminproject/Tables
        public ActionResult Index()
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                List<Student> students = db.Students.ToList();
                return View(students);

            }
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Teach()
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                List<Teacher> teachers = db.Teachers.ToList();
                return View(teachers);

            }
        }

        [HttpGet]
        public ActionResult CreateTeacher()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateTeacher(Teacher teacher)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
            }

            return RedirectToAction("Teach");
        }

        public ActionResult Empl()
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                List<Employee> employees = db.Employees.ToList();
                return View(employees);

            }
        }

        [HttpGet]
        public ActionResult CreateEmp()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateEmp(Employee employee)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }

            return RedirectToAction("Empl");
        }
        public ActionResult Delete(int id)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                Student student = db.Students.FirstOrDefault(s => s.Id == id);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();

                }
                else
                {
                    return HttpNotFound();
                }

            }
            return RedirectToAction("Index");

        }
        public ActionResult DeleteTeacher(int id)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                Teacher teacher = db.Teachers.FirstOrDefault(s => s.Id == id);
                if (teacher != null)
                {
                    db.Teachers.Remove(teacher);
                    db.SaveChanges();

                }
                else
                {
                    return HttpNotFound();
                }

            }
            return RedirectToAction("Teach");

        }
        public ActionResult DeleteEmployee(int id)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                Employee employee = db.Employees.FirstOrDefault(s => s.Id == id);
                if (employee != null)
                {
                    db.Employees.Remove(employee);
                    db.SaveChanges();

                }
                else
                {
                    return HttpNotFound();
                }

            }
            return RedirectToAction("Empl");

        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditTeacher(Teacher teacher)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                db.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Teach");
        }
        [HttpPost]
        public ActionResult EditEmpl(Employee employee)
        {
            using (KarateSchoolEntities db = new KarateSchoolEntities())
            {
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Empl");
        }


    }
}