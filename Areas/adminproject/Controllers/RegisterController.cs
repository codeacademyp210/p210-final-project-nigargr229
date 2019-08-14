using Area.Models;
using Area.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.adminproject.Controllers
{
    public class RegisterController : Controller
    {
        KarateSchoolEntities db = new KarateSchoolEntities();

        // GET: adminproject/Register
        public ActionResult Index()
        {
            return View();
        }

       

    }
}