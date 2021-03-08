using Domain.Custumer;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.UnitOfWork.Mapping
{
    internal class CustumerMap :ClassMap <Custumer>
    {
        internal CustumerMap()
        {
            Table("Custumer");

            Id(c => c.Id)
                .GeneratedBy
                .GuidComb();

            Map(c => c.Name, "Name")
                .CustomSqlType("varchar(30)")
                .Not
                .Nullable();

        }
    }
}
