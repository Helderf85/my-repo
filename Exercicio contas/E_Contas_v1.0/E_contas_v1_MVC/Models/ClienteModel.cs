using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_contas_v1_MVC.Models
{
    public class ClienteModel
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }

        public string Morada { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }

    }
}
