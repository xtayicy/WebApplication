using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext (DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication.Models.Book> Book { get; set; }

        public DbSet<WebApplication.Models.Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Book>().ToTable(Common.Table_Book);
            modelBuilder.Entity<Person>().ToTable(Common.Table_Person);
        }
    }
}
