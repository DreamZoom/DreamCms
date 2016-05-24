using Dream.Author;
using Dream.Authorize;
using Dream.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dream.Cms.Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            /* 
             * 设置数据库主体
             * */
            EntityContextProvider.RegisterFactory<CmsContext>();
            /*
             * 设置权限验证方式
             * */
            AuthorProvider.Author = new RoleAuthor();

            /*
             * 设置管理员对象
             * */
            ManagerProvider.Manager = new RoleManager();

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            
        }
    }
}