using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Models.Entity.ORM
{
    public class CSharpDemoContext : DbContext, ICSharpDempContext
    {
        public CSharpDemoContext() : base("CSharpDemoContext")
        {

        }

        public DbSet<Contact> Contacts { set; get; }

        public DbSet<Enrollment> Enrollments { set; get; }

        public DbSet<Group> Groups { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
