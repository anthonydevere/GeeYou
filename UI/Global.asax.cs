using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace UI
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
        //    ServicePointManager.Expect100Continue = true;
        //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
        //                                           | SecurityProtocolType.Tls11
        //                                           | SecurityProtocolType.Tls12
        //                                           | SecurityProtocolType.Ssl3;
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
         }

    }
}