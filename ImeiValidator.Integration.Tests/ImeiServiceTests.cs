using System.IO;
using System.Net;
using System.ServiceModel;
using System.Threading.Tasks;

using Autofac;

using ImeiValidator.WebService;
using ImeiValidator.WebService.ImeiService;

using NUnit.Framework;

namespace ImeiValidator.Integration.Tests
{
    [TestFixture]
    public class ImeiServiceTests
    {
        [Test]
        public void TestCallImeiServiceFromWebRequest()
        {
            var webRequest = (HttpWebRequest)WebRequest.Create("http://213.156.91.27/micsservice.asmx/GetItemStatusByImei?imei=463363636");
            using (var response = webRequest.GetResponse())
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Assert.That(result, Is.EqualTo("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<string xmlns=\"http://www.ucrf.gov.ua/webservices/\">Невідомий формат даних '463363636'</string>"));
                }
            }
        }

        [Test]
        public void TestCallImeiService()
        {
            var service = new MicsServiceSoapClient();

            var result = service.GetItemStatusByImei("463363636");
            Assert.That(result, Is.EqualTo("Невідомий формат даних '463363636'"));
        }

        [Test]
        public async Task TestCallImeiServiceFromTask()
        {
            var service = new MicsServiceSoapClient();

            var result = await service.GetItemStatusByImeiAsync("463363636");
            Assert.That(result, Is.EqualTo("Невідомий формат даних '463363636'"));
        }

        [Test]
        public void TestCallImeiServiceProgrammatically()
        {
            var basicHttpBinding = new BasicHttpBinding();
            var endpointAddress = new EndpointAddress("http://213.156.91.27/micsservice.asmx");
            var channelFactory = new ChannelFactory<MicsServiceSoap>(basicHttpBinding, endpointAddress);
            var service = channelFactory.CreateChannel();

            var result = service.GetItemStatusByImei("463363636");

            Assert.That(result, Is.EqualTo("Невідомий формат даних '463363636'"));
            ((IClientChannel)service).Close();
            channelFactory.Close();
        }

        [Test]
        public void TestCallImeiServiceFromAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ImeiServiceRegistrations());
            var container = builder.Build();

            var result = container.Resolve<MicsServiceSoap>().GetItemStatusByImei("463363636");

            Assert.That(result, Is.EqualTo("Невідомий формат даних '463363636'"));
        }
    }
}
