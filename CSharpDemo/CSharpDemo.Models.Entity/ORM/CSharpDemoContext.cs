﻿
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Models.Common;

namespace CSharpDemo.Models.Entity.ORM
{
    public class CSharpDemoContext : DbContext
    {
        public readonly Guid Identity;

        public CSharpDemoContext() : base("name=CSharpDemoContext")
        {
            Identity = Guid.NewGuid();
        }

        public DbSet<ZJBankCode> ZJBankCodes { set; get; }

        public CSharpDemoContext Context
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
