using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xero_api.ViewModels
{
    public class XeroErrors
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
        public object Extensions { get; set; }
        public bool IsSuccess { get; set; }
    }
}
