using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NHibernate.Linq;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQuaryableRepository<T>:IQuaryableRepository<T> where T:class,IEntity,new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;

        public NhQuaryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table
        {
            get { return this.Entities; }
        }

        protected virtual IQueryable<T> Entities
        {
            get { return _entities ?? (_entities = _nHibernateHelper.SessionFactory.OpenSession().Query<T>()); }
        }
    }
}
