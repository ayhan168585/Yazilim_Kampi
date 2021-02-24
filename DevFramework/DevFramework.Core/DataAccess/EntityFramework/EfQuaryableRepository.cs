using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQuaryableRepository<T>:IQuaryableRepository<T>where T:class,IEntity,new()
    {
        private DbContext _context;
        private DbSet<T> _entities;

        public EfQuaryableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => this.Entities;

        protected virtual DbSet<T> Entities
        {
            get { return _entities ?? (_entities = _context.Set<T>()); }
        }
    }
}
