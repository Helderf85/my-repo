using Domain.Product;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.UnitOfWork.Mapping
{
    internal class ProductMap: ClassMap<Product>
    {
        internal ProductMap()
        {
            Table("Product");

            Id(c => c.Id)
                .GeneratedBy
                .GuidComb();

            Map(c => c.Descricao, "Descricao")
                .CustomSqlType("varchar(80)")
                .Not
                .Nullable();
        }
    }
}
