using Domain.Core;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Core
{
    public class Repository<TEntity>
        : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly IQueryableUnitOfWork _unitOfWork;

        public Repository(IQueryableUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        private ISession GetSet()
        {
            return _unitOfWork.CreateSet();
        }

        public async Task Add(TEntity item)
        {
            try
            {
                if (item != null)

                    await GetSet().SaveAsync(item);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Delete(TEntity item)
        {
            if (item != null)

                await GetSet().DeleteAsync(item);
        }

        public async Task<TEntity> Get(Guid id)
        {
            try
            {
                if (id != default)
                {
                    return await GetSet().GetAsync<TEntity>(id);
                }
                return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Modify(TEntity item)
        {
            if (item != null)

                await GetSet().UpdateAsync(item);
        }
    }
}
