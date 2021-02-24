using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NHibernate.Linq;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase<TEntity>:IEntityRepository<TEntity>
    where TEntity:class,IEntity,new()
    {
        private NHibernateHelper _nHibernateHelper;

        public NhEntityRepositoryBase(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return filter == null
                    ? session.Query<TEntity>().ToList()
                    : session.Query<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
            throw new NotImplementedException();
        }

        public TEntity Add(TEntity entity)
        {
            using (var session=_nHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Delete(entity);
               
            }
        }
    }
}
