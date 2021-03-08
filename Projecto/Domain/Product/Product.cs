using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product
{
    public class Product:Entity 
    {
        protected Product (string descricao, decimal preco)
        {
            Descricao = descricao;
            Preco = preco;
        }

        public string Descricao { get; private set; }

        public decimal Preco { get; private set; }
    }

}
