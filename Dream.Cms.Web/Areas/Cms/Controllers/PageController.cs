using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dream.Cms.Web.Areas.Cms.Controllers
{
    public class PageController : Controller
    {
        //
        // GET: /Cms/Page/

        public ActionResult Show(string page)
        {
            return Content(page);
        }

    }
}
