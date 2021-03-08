using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedService.Model
{
    public class OrderItemModel
    {
        public Guid ProductId { get; set; }
        public int Quantidade { get; set; }
    }
}
