using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dream.Cms.Web.Controllers
{
    [ValidateInput(false)]
    public class ArticleController : ManageControllerBase<ArticleService, Article>
    {
       
    }
}
