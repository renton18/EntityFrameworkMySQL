namespace NameList.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NameListDbContext : DbContext
    {
        public NameListDbContext()
            : base("name=NameListDbContext")
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
