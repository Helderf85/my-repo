using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace E_contas_v1_MVC.Service
{
    public interface ICustomerService
    {

        HttpClient GetClient();
    }
}
