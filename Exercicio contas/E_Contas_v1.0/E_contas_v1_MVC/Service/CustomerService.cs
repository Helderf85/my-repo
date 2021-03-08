using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace E_contas_v1_MVC.Service
{
    public class CustomerService : ICustomerService
    {

        private readonly IHttpContextAccessor httpContextAccessor;



        HttpClient _httpClient = new HttpClient();

        public CustomerService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public HttpClient GetClient()
        {
            _httpClient.BaseAddress = new Uri("http://localhost:53649");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return _httpClient;
        }
    }
}
