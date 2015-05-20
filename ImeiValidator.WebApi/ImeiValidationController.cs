using System.Web.Http;

using ImeiValidator.BusinessLayer;
using ImeiValidator.WebApi.Models;

namespace ImeiValidator.WebApi
{
    public class ImeiValidationController : ApiController
    {
        private readonly IImeiProvider _imeiProvider;

        public ImeiValidationController(IImeiProvider imeiProvider)
        {
            _imeiProvider = imeiProvider;
        }

        [HttpPost, ActionName("validateImei")]
        public ImeiResponse ValidateImei(ImeiRequest request)
        {
            return new ImeiResponse { Status = _imeiProvider.GetImeiStatus(request.Number) };
        }
    }
}