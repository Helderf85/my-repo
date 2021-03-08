using Domain.Order;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.UnitOfWork.Mapping
{
    internal class OrderMap: ClassMap<Order>
    {
        internal OrderMap()
        {
            Table("Order");

            Id(c => c.Id)
                .GeneratedBy
                .GuidComb();

            Map(c => c.OrderDate, "OrderDate")
                .CustomSqlType("DateTime")
                .Not
                .Nullable();

           
            HasMany(t => t.OrderItem)
                .ForeignKeyConstraintName("FK_ORDE_ORIT_01")
                .KeyColumn("OrderItemId")
                .Not
                .KeyNullable();

            References(t => t.Custumer)
                .ForeignKey("FK_ORDE_CUST_01")
                .Column("CustumerId")
                .Not
                .Nullable();

        }
    }
}
