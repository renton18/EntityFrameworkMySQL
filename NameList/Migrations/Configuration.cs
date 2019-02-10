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
            //p.acountName�������Ȃ�Ώ㏑�������
            context.Persons.AddOrUpdate(p => p.personId
                , new Person(1, "����", 1, "user@yahoo.co.jp", "09099999999", "", DateTime.Now, DateTime.Now)
                , new Person(2, "�O��", 2, "user@yahoo.co.jp", "09099999999", "", DateTime.Now, DateTime.Now)
                , new Person(3, "�g�{", 2, "user@yahoo.co.jp", "09099999999", "", DateTime.Now, DateTime.Now)
                , new Person(4, "����", 2, "user@yahoo.co.jp", "09099999999", "", DateTime.Now, DateTime.Now)
            );
            context.Departments.AddOrUpdate(p => p.departmentId
                , new Department(1, "�V�X�e����", 1, DateTime.Now, DateTime.Now)
                , new Department(2, "�o����", 2, DateTime.Now, DateTime.Now)
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
