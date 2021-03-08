using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Core
{
    public interface IUnitOfWork
    {
        void BeginTansaction();

        Task Commit();

        Task Rollback();
    }
}
