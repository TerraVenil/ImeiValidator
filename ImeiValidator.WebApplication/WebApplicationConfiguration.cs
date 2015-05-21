using System.Configuration;

namespace ImeiValidator.WebApplication
{
    public class WebApplicationConfiguration
    {
        public static bool EnableOptimizations
        {
            get
            {
                return bool.Parse(ConfigurationManager.AppSettings["EnableOptimizations"]);
            }
        }
    }
}