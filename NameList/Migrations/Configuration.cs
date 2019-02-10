namespace NameList.Migrations
{
    using MySql.Data.Entity;
    using MySql.Data.MySqlClient;
    using NameList.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<NameList.Model.NameListDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "NameList.Model.NameListDbContext";
            SetHistoryContextFactory("MySql.Data.MySqlClient", (conn, schema) => new NameListDbContext2(conn, schema));
        }

        protected override void Seed(NameList.Model.NameListDbContext context)
        {
            //p.acountNameが同じならば上書きされる
            context.Persons.AddOrUpdate(p => p.personId
                , new Person(1, "佐藤", 1, "user@yahoo.co.jp", "09099999999", "", DateTime.Now, DateTime.Now)
                , new Person(2, "三上", 2, "user@yahoo.co.jp", "09099999999", "", DateTime.Now, DateTime.Now)
                , new Person(3, "吉本", 2, "user@yahoo.co.jp", "09099999999", "", DateTime.Now, DateTime.Now)
                , new Person(4, "村上", 2, "user@yahoo.co.jp", "09099999999", "", DateTime.Now, DateTime.Now)
            );
            context.Departments.AddOrUpdate(p => p.departmentId
                , new Department(1, "システム課", 1, DateTime.Now, DateTime.Now)
                , new Department(2, "経理課", 2, DateTime.Now, DateTime.Now)
            );
        }

        public class MysqlConfiguration : DbConfiguration
        {
            public MysqlConfiguration()
            {
                AddDependencyResolver(new MySqlDependencyResolver());

                SetProviderFactory(MySqlProviderInvariantName.ProviderName, new MySqlClientFactory());

                SetDefaultConnectionFactory(new MySqlConnectionFactory());

                SetMigrationSqlGenerator(MySqlProviderInvariantName.ProviderName, () => new MySqlMigrationSqlGenerator());

                SetProviderServices(MySqlProviderInvariantName.ProviderName, new MySqlProviderServices());

                SetProviderFactoryResolver(new MySqlProviderFactoryResolver());

                SetManifestTokenResolver(new MySqlManifestTokenResolver());
                SetMigrationSqlGenerator(MySqlProviderInvariantName.ProviderName, () => new MySqlMigrationSqlGenerator());
            }
        }
    }
}
