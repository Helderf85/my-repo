using Domain.Custumer;
using Infrastructure.Data.Core;
using Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class CustumerRepository: Repository<Custumer>, ICustumerRepository
    {
        public CustumerRepository(IOrderUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
