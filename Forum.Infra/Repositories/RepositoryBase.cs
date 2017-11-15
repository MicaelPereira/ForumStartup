using Forum.Domain.Interfaces.Repositories;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ISession Db = NHibernateHelper.OpenSession();

        public void Add(TEntity obj)
        {
            Db.Save(obj);
        }

        public TEntity GetById(int id)
        {
            return Db.Get<TEntity>(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.QueryOver<TEntity>().List();
        }

        public void Update(TEntity obj)
        {
            Db.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            Db.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
