using ImeiValidator.WebService.ImeiService;

using Moq;

using NUnit.Framework;

namespace ImeiValidator.NUnitTests
{
    [TestFixture]
    public class ImeiProviderTests
    {
        [Test]
        public void TestGetImeiStatus()
        {
            var imeiService = new Mock<MicsServiceSoap>();
            imeiService.Setup(x => x.GetItemStatusByImei("8965431")).Returns("Невідомий формат даних '8965431'");
            var imeiProvider = new ImeiProvider(imeiService.Object);

            var result = imeiProvider.GetImeiStatus("8965431");

            Assert.That(result, Is.EqualTo("Невідомий формат даних '8965431'"));
        }
    }
}
