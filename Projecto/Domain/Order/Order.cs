using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Order
{
    using Domain.Custumer;

    public class Order:Entity 
    {
        

        protected Order(DateTime orderDate, List<OrderItem> orderItem, Custumer custumer)
        {
            OrderDate = orderDate;
            OrderItem = orderItem;
            Custumer = custumer;
        }

        public DateTime OrderDate { get; private set; }
        public List<OrderItem> OrderItem { get; private set; }
        public Custumer Custumer { get; set; }
    }
}
