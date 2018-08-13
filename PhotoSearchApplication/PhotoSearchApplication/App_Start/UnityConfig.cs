using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace PhotoSearchApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            //Note: Before grabbing the Unity.WebApi I already set it up via WebApiConfig.cs
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}