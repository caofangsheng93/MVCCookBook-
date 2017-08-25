using MvcBootstrapEditor.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcBootstrapEditor
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //注册压缩
            BundleConfig.RegisterBundles(BundleTable.Bundles);
          
            //启用压缩 默认是没有启用的   .或者修改配置文件中的
            // <compilation debug="true" targetFramework="4.5"/>把debug改为false就可以了，就可以同样启用压缩了
            BundleTable.EnableOptimizations = true;
        }
    }
}
