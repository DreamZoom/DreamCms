using Dream.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dream.Cms.Web.Controllers
{
    [ValidateInput(false)]
    [Author.Author]
    public class SiteConfigController : Controller
    {
        
        public ActionResult Config()
        {
            var config = ConfigProvider.Load<SiteConfig>();
            return View(config);
        }

        [HttpPost]
        public ActionResult Config(SiteConfig config)
        {
            if (ModelState.IsValid)
            {
                if (ConfigProvider.Save<SiteConfig>(config))
                {
                    return RedirectToAction("config");
                }
                ModelState.AddModelError("","保存失败");
            }
            return View(config);
        }

    }
}
