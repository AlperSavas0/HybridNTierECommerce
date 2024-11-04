using HybridNTierECommerce.BLL.Services.Abstracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Services.Concretes
{
    public class ApiService : IApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<(bool, string)> MakePostRequestAsync(string endpoint, object data)
        {
            HttpClient client = _httpClientFactory.CreateClient();
            string jsonData= JsonConvert.SerializeObject(data);
            StringContent content= new StringContent(jsonData,Encoding.UTF8,"application/json");

            HttpResponseMessage responseMessage= await client.PostAsync(endpoint, content);
            string responseBody= await responseMessage.Content.ReadAsStringAsync();
            return (responseMessage.IsSuccessStatusCode, responseBody);
        }
    }
}
