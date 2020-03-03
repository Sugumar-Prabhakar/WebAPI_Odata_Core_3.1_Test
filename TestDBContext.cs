using Microsoft.EntityFrameworkCore;
using Odata_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odata_3_1
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options)
           : base(options)
        {
        }

        public DbSet<TestCase> TestCase { get; set; }
        public DbSet<TestSuite> TestSuite { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestCase>().HasOne(t => t.TestSuite).WithMany(t => t.TestCases).HasForeignKey(t => t.TestSuiteId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
