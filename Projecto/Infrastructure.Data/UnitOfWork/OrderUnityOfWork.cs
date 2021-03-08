using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Custumer;
using Domain.Order;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using System.Reflection;

namespace Infrastructure.Data.UnitOfWork
{
    public class OrderUnityOfWork
        : IOrderUnitOfWork
    {
        private static readonly ISessionFactory SessionFactory;
        private readonly ISession _session;

        private ITransaction _transaction;

        private IQueryable<Custumer> _custumer;
        public IQueryable<Custumer> Custumer => _custumer ?? (_custumer = _session.Query<Custumer>());

        private IQueryable<Order> _order;
        public IQueryable<Order> Order => _order ?? (_order = _session.Query<Order>());

        static OrderUnityOfWork()
        {
            SessionFactory = BuildSessionFactory();
        }
        private static ISessionFactory BuildSessionFactory()
        {
            try
            {
                return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=LAPTOP-VQPN3HBJ;Initial Catalog=Db_Order;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                .Mappings(m => m.FluentMappings
                .AddFromAssembly(Assembly.GetExecutingAssembly())
                .Conventions
                .Add(DefaultLazy.Never()))
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true)).BuildSessionFactory();
                //primeira vez que se cria o banco tem que estar true depois sempre false
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public OrderUnityOfWork()
        {
            _session = SessionFactory.OpenSession();
        }

        public void BeginTansaction()
        {
            _transaction = _session.BeginTransaction();
        }



        public async Task Commit()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                {
                    await _transaction.CommitAsync();
                }
            }
            catch (Exception)
            {
                if (_transaction != null && _transaction.IsActive)
                {
                    await _transaction.RollbackAsync();
                }

                throw;
            }
            finally
            {
                _session.Dispose();
            }
        }

        public ISession CreateSet()
        {
            return _session;
        }

        public async Task Rollback()
        {
            if (_transaction != null && _transaction.IsActive)
            {
                await _transaction.RollbackAsync();
            }
        }
    }
}
