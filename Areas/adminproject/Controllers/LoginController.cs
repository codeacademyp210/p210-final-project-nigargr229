using Area.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Area.Areas.adminproject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        Area.Models.KarateSchoolEntities db = new Area.Models.KarateSchoolEntities();
        [AllowAnonymous]

        // GET: adminproject/Login
      [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]

        public ActionResult Index(SystemUsr systemUser)
        {
           var UserDb = db.SystemUsrs.FirstOrDefault(x => x.Name == systemUser.Name && x.Password == systemUser.Password);
            if (UserDb!=null)
            {
                FormsAuthentication.SetAuthCookie(UserDb.Name,false);
                return RedirectToAction("Index","Dashboard");
            }
            else
            {
                ViewBag.Message = "Username or password is not true";
                return View();
            }

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Register(SystemUsr systemUser)
        {
            db.SystemUsrs.Add(systemUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
   
    }
}