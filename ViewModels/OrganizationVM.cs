using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xero_api.ViewModels
{
    public class OrganizationVM //: XeroErrors
    {
        public string Id { get; set; }
        public string TenantId { get; set; }
        public string TenantType { get; set; }
        public string TenantName { get; set; }
        public DateTime CreatedDateUtc { get; set; } = DateTime.Now;
        public DateTime? UpdatedDateUtc { get; set; }
    }
}
