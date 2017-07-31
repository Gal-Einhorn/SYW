using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace SYW.SUE.DataBase
{
    public class SessionFactoryInitializer
    {
        private static ISessionFactory InitiateSession()
        {
            return Fluently.Configure()
                .Database(
                MySQLConfiguration.Standard.ConnectionString(
                c => c.FromConnectionStringWithKey("MyConnectionString")))
                .BuildSessionFactory();
        }
    }
}