using System.Web.Mvc;

namespace Area.Areas.adminproject
{
    public class adminprojectAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "adminproject";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "adminproject_default",
                "adminproject/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Area.Areas.adminproject.Controllers" }
            );
        }
    }
}