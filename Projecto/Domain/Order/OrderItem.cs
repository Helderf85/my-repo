using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Order
{
    using Domain.Product;

    public abstract class OrderItem: Entity 
    {
        protected OrderItem(int quantidade,  Product product)
        {
            Quantidade = quantidade;
            Product = product;
        }

        public Product Product { get; private set; }
        public int Quantidade { get; private set; }
    }
}
