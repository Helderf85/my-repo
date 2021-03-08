using Domain.Order;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.UnitOfWork.Mapping
{
    internal class OrderItemMap: ClassMap<OrderItem>
    {
        internal OrderItemMap()
        {
            Table("OrderItem");

            Id(c => c.Id)
                .GeneratedBy
                .GuidComb();

            Map(c => c.Quantidade, "Quantidade")
                .CustomSqlType("Int")
                .Not
                .Nullable();

            References(t => t.Product)
                .ForeignKey("FK_ORIT_PROD_01")
                .Column("ProductId")
                .Not
                .Nullable();

            
        }

    }
}
