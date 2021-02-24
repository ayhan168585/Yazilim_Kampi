using System.Reflection;
using DevFramework.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace DevFramework.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper:NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(p => p.Server(@"DESKTOP-HTDLLF0\SQLEXPRESS").Database("Northwind").TrustedConnection()))
                .Mappings(p => p.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}
