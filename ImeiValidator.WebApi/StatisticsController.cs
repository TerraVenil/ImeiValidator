using System.Collections.Generic;
using System.Web.Http;

using ImeiValidator.WebApi.Models;

namespace ImeiValidator.WebApi
{
    public class StatisticsController : ApiController
    {
        [HttpGet, ActionName("getStatisticByRegions")]
        public IList<ChartResponse> GetStatisticByRegions()
        {
            return new List<ChartResponse>
                       {
                           new ChartResponse { Label = "Волинська", Value = 16, Color = "#F7464A" },
                           new ChartResponse { Label = "Київська", Value = 28, Color = "#4D5360" },
                           new ChartResponse { Label = "Чернигівська", Value = 15, Color = "#00FF00" },
                           new ChartResponse { Label = "Львівська", Value = 14, Color = "#248F24" },
                           new ChartResponse { Label = "Донецька", Value = 19, Color = "#7DDEFF" },
                           new ChartResponse { Label = "Дніпропетровська", Value = 5, Color = "#336680" }
                       };
        }

        [HttpGet, ActionName("getMostPopularMaskNumbers")]
        public IList<ChartResponse> GetMostPopularMaskNumbers()
        {
            return new List<ChartResponse>
                       {
                           new ChartResponse { Label = "0129*", Value = 65, Color = "#4747D1" },
                           new ChartResponse { Label = "5223*", Value = 20, Color = "#FF19FF" },
                           new ChartResponse { Label = "8856*", Value = 5, Color = "#5C5C33" },
                           new ChartResponse { Label = "5896*", Value = 7, Color = "#CC6699" }
                       };
        }

        [HttpGet, ActionName("getRelationPhones")]
        public IList<ChartResponse> GetRelationPhones()
        {
            return new List<ChartResponse>
                       {
                           new ChartResponse { Label = "Чорні", Value = 75, Color = "#F7464A" },
                           new ChartResponse { Label = "Білі", Value = 23, Color = "#4D5360" }
                       };
        }
    }
}
