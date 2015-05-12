using System;
using System.Threading.Tasks;

using ImeiValidator.WebService.ImeiService;

namespace ImeiValidator
{
    public class ImeiProvider : IImeiProvider
    {
        private readonly MicsServiceSoap _service;

        public ImeiProvider(MicsServiceSoap service)
        {
            _service = service;
        }

        public bool IsImeiValid(string imei)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsImeiValidAsync(string imei)
        {
            throw new NotImplementedException();
        }

        public string GetImeiStatus(string imei)
        {
            return _service.GetItemStatusByImei(imei);
        }
    }
}