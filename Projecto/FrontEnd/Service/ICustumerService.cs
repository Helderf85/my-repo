using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Service
{
    public interface ICustumerService
    {
        HttpClient GetClient();
    }
}
