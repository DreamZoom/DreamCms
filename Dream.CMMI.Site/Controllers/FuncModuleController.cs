using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dream.CMMI.Site.Controllers
{
    public class FuncModuleController : ManageControllerBase<FuncModuleService, FuncModule>
    {
        
        /// <summary>
        /// treegrid 结构数据
        /// </summary>
        /// <returns></returns>

        public ActionResult GetTreeList()
        {
            var treeList = Service.GetTreeList();
            return JsonP(new { result = true, data = treeList });
        }


        public ActionResult FuncModuleTree()
        {
            return View();
        }

    }
}
