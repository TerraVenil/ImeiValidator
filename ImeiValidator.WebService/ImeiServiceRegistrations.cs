using System.ServiceModel;

using Autofac;
using Autofac.Integration.Wcf;

using ImeiValidator.WebService.ImeiService;

namespace ImeiValidator.WebService
{
    public class ImeiServiceRegistrations : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new ChannelFactory<MicsServiceSoap>(new BasicHttpBinding(), new EndpointAddress("http://213.156.91.27/micsservice.asmx"))).SingleInstance();

            builder.Register(c => c.Resolve<ChannelFactory<MicsServiceSoap>>().CreateChannel()).As<MicsServiceSoap>().UseWcfSafeRelease(); 
        }
    }
}