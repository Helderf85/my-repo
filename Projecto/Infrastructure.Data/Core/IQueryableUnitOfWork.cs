using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Core
{
    public interface IQueryableUnitOfWork:IUnitOfWork
    {
        ISession CreateSet();
    }
}
