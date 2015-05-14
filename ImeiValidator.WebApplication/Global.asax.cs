using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Autofac;
using Autofac.Integration.WebApi;

using ImeiValidator.BusinessLayer;
using ImeiValidator.WebApplication.AutofacModules;
using ImeiValidator.WebService;

namespace ImeiValidator.WebApplication
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            builder.RegisterModule(new ImeiServiceRegistrations());
            builder.RegisterType<ImeiProvider>().As<IImeiProvider>().SingleInstance();
            builder.RegisterModule(new WebApiControllerRegistrations());
            var container = builder.Build();

            var webApiResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;
        }
    }
}
