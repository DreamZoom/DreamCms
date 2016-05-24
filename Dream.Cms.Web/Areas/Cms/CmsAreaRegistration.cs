using System.Web.Mvc;

namespace Dream.Cms.Web.Areas.Cms
{
    public class CmsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Cms";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Cms_page_show",
                "Cms/{page}/q.html",
                new { controller = "Page", action = "Show", page="2" }
            );
            //context.MapRoute(
            //    "Cms_default",
            //    "Cms/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
