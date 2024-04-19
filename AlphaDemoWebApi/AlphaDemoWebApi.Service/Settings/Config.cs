using AlphaDemoWebApi.Service.Interface.Settings;
using System.Configuration;

namespace AlphaDemoWebApi.Service.Settings
{
    public class Config : IConfig
    {
        public string BaseUrl()
        {
            return ConfigurationManager.AppSettings["BaseUrl"] ?? string.Empty;
        }
    }
}
