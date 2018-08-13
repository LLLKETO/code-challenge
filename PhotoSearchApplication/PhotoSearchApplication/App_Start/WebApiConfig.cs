using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using Unity.Lifetime;
using CommonServiceLocator;
using PhotoSearchApplication.Models;
using PhotoSearchApplication.Proxys;


namespace PhotoSearchApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //NOTE: UnityConfig can take on the below dependencies
            var container = new UnityContainer();
            container.RegisterType<IFlickrApiProxy, FlickrApiProxy>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityDependencyResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            //Note: This is just defaulted for now since we do not have any other API calls at the moment
            //We would want to have different routes for our different controllers and calls
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{q}"
            );
        }
    }
}
