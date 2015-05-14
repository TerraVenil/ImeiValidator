using System.Web.Http;

using ImeiValidation.WebApi.Models;

using ImeiValidator.BusinessLayer;

namespace ImeiValidation.WebApi
{
    public class ImeiValidationController : ApiController
    {
        private readonly IImeiProvider _imeiProvider;

        public ImeiValidationController(IImeiProvider imeiProvider)
        {
            _imeiProvider = imeiProvider;
        }

        [HttpPost]
        public ImeiResponse ValidateImei(ImeiRequest request)
        {
            return new ImeiResponse { Status = _imeiProvider.GetImeiStatus(request.Number) };
        }
    }
}