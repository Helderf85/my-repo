using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FrontEnd.Service
{
    public class CustumerService : ICustumerService
    {
        private readonly IHttpContextAccessor httpContextAcessor;


        private HttpClient _httpClient = new HttpClient();


        public CustumerService(IHttpContextAccessor httpContextAcessor)
        {
            this.httpContextAcessor = httpContextAcessor;
        }
        public HttpClient GetClient()
        {
            _httpClient.BaseAddress = new Uri("https://localhost:44386/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return _httpClient;
        }
    }
}
