using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dream.CMMI.Site.Controllers
{
    public class CmmiProjectController : ManageControllerBase<CmmiProjectService,CmmiProject>
    {
        //
        // GET: /CmmiProject/

        public ActionResult Index()
        {
            return View();
        }

    }
}
