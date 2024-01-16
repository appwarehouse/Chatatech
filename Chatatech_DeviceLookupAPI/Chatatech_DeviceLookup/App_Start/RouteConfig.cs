using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Chatatech_DeviceLookup
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            RouteTable.Routes.MapHttpRoute("apis", "API/{controller}/{id}", null, null, new APIKeyMessageHandler(GlobalConfiguration.Configuration));
            RouteTable.Routes.MapHttpRoute("apisNoId", "API/{controller}", null, null, new APIKeyMessageHandler(GlobalConfiguration.Configuration));


        }
    }
}
