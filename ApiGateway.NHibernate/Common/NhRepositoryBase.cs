using ApiGateway.Common;
using ApiGateway.CrossCutting.Transactions.NHibernate;
using NHibernate;
using System.Linq;

namespace ApiGateway.NHibernate.Common
{
    public abstract class NhRepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : IAggregateRoot
    {
        protected ISession Session
        {
            get { return NhUnitOfWork.Session; }
        }

        public IQueryable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        public TEntity Get(TPrimaryKey key)
        {
            return Session.Get<TEntity>(key);
        }

        public void Insert(TEntity entity)
        {
            Session.Save(entity);
        }

        public void Update(TEntity entity)
        {
            Session.Update(entity);
        }

        public void Delete(TPrimaryKey id)
        {
            Session.Delete(Session.Load<TEntity>(id));
        }
    }
}