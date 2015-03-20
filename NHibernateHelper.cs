using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository {
    public class NHibernateHelper {

        [ThreadStatic]
        private static Dictionary<string, ISessionFactory> dictionary;

        private static ISessionFactory getStaticSessionFactory(String connectionString, String defaultSchema) {
            if (null == dictionary)
                dictionary = new Dictionary<string, ISessionFactory>();
            if (!dictionary.ContainsKey(connectionString))
                dictionary.Add(connectionString, InitializeSessionFactory(connectionString, defaultSchema));
            return dictionary[connectionString];
        }

        private static ISessionFactory createSessionFactory(String connectionString, String defaultSchema) {
            return Fluently.Configure()

                .Database(MsSqlConfiguration.MsSql2000.DefaultSchema(defaultSchema)

                              .ConnectionString(connectionString)

                )

                .Mappings(m =>

                          m.FluentMappings

                              .AddFromAssemblyOf<GlobalPhone>())

                .ExposeConfiguration(cfg => new SchemaExport(cfg)

                                                .Create(false, false))

                .BuildSessionFactory();
        }

        private static ISessionFactory InitializeSessionFactory(String connectionString, String defaultSchema) {
            return createSessionFactory(connectionString, defaultSchema);
        }

        public static ISession OpenSession(String connectionString, String defaultSchema) {
            return getStaticSessionFactory(connectionString, defaultSchema).OpenSession();
        }
        /// <summary>
        /// Вызов сессии с default Shema 'dbo'
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static ISession OpenSession(String connectionString) {
            return getStaticSessionFactory(connectionString, "dbo").OpenSession();
        }

        public static ISession OpenNewSession(String connectionString) {
            return createSessionFactory(connectionString, "dbo").OpenSession();
        }
    }
}
