using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetUrlRewriteDemo.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Action1Html", // action伪静态    
                url: "{controller}/{action}.html",// 带有参数的 URL    
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }// 参数默认值    
            );

            routes.MapRoute(
                name:"IDHtml", // id伪静态    
                url:"{controller}/{action}/{id}.html",// 带有参数的 URL    
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }// 参数默认值    
            );

            routes.MapRoute(
                name: "ActionHtml", // action伪静态    
                url: "{controller}/{action}.html/{id}",// 带有参数的 URL    
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }// 参数默认值    
            );

            routes.MapRoute(
                name: "ControllerHtml", // controller伪静态    
                url: "{controller}.html/{action}/{id}",// 带有参数的 URL    
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }// 参数默认值    
            );

            routes.MapRoute(
                name:"Root",
                url: "",
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }//根目录匹配    
            ); 

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}