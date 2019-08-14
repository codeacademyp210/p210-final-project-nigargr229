using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.adminproject.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: adminproject/Dashboard
       
        public ActionResult Index()
        {
            return View();
        }
    }
}