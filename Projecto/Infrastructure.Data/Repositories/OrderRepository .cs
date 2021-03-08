using Domain.Order;
using Infrastructure.Data.Core;
using Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class OrderRepository : Repository<Order>,IOrderRepository
    {
        public OrderRepository(IOrderUnitOfWork unitOfWork): base(unitOfWork)
        {

        }
    }
}
