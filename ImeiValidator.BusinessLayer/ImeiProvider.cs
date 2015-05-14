using ImeiValidator.WebService.ImeiService;

namespace ImeiValidator.BusinessLayer
{
    public class ImeiProvider : IImeiProvider
    {
        private readonly MicsServiceSoap _service;

        public ImeiProvider(MicsServiceSoap service)
        {
            _service = service;
        }

        public string GetImeiStatus(string imei)
        {
            return _service.GetItemStatusByImei(imei);
        }
    }
}