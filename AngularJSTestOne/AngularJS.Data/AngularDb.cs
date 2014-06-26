using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJS.Data
{
    public class AngularDb : DbContext
    {
        public AngularDb()
            : base("name=AngularDb")
            {
            }

            public DbSet<Employee> Employees { get; set; }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Employee>().HasKey(t => t.Id);
                modelBuilder.Entity<Employee>()
                    .Property(t => t.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            }
    }
}
