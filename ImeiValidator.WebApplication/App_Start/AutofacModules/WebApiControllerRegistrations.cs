using Autofac;

using ImeiValidator.WebApi;

namespace ImeiValidator.WebApplication.AutofacModules
{
    public class WebApiControllerRegistrations : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ImeiValidationController>().InstancePerRequest();
        }
    }
}