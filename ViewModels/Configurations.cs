using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xero_api.ViewModels
{
    public class Configurations
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
        public string TenandId { get; set; }
        public string Url { get; set; }
        public string CallbackUrl { get; set; }
    }
}
