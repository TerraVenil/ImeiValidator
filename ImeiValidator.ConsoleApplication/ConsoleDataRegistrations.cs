using Autofac;

namespace ImeiValidator.ConsoleApplication
{
    public class ConsoleDataRegistrations : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ImeiProvider>().As<IImeiProvider>().SingleInstance();
        }
    }
}