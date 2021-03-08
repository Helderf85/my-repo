using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Core
{
    public interface IRepository<TEntity>
        where TEntity:Entity
    {
        Task Add(TEntity item);
        Task<TEntity> Get(Guid id);
        Task Modify(TEntity item);
        Task Delete(TEntity item);
    }
}
