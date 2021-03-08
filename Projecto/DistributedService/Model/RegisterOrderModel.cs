using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedService.Model
{
    public class RegisterOrderModel
    {

        public DateTime OrderDate { get; set; }
        public Guid OrderItemId { get; set; }
        public Guid  CustumerId { get; set; }
    }
}
