using Domain.Custumer;
using Domain.Order;
using Infrastructure.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.UnitOfWork
{
    public interface IOrderUnitOfWork: IQueryableUnitOfWork
    {
        IQueryable<Custumer> Custumer { get; }

        IQueryable<Order> Order { get; }

    }
}
