using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xero_api.ViewModels;

namespace xero_api.Services
{
    public interface IXeroService
    {
        Task<Object> GetOrganizations();
    }

    public class XeroService : IXeroService
    {
        private readonly Configurations _settings;

        public XeroService(IOptions<Configurations> options)
        {
            _settings = options.Value;
        }

        public async Task<Object> GetOrganizations()
        {
            var _client = new RestClient($"{_settings.Url}/connections");
            _client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + _settings.AccessToken);
            var response = await _client.ExecuteAsync<IList<OrganizationVM>>(request);

            return new
            {
                content = response.IsSuccessful ? response.Data : null,
                error = response.IsSuccessful ? null : JsonConvert.DeserializeObject<XeroErrors>(response.Content),
                success = response.IsSuccessful
            };

        }
    }
}
