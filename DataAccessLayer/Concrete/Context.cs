using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database=MvcProjeKampi; integrated security=true; TrustServerCertificate=true; MultipleActiveResultSets=True");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Content>()
        //   .HasOne(c => c.Heading)
        //   .WithMany(h => h.Contents)
        //   .HasForeignKey(c => c.HeadingID)
        //   .OnDelete(DeleteBehavior.NoAction);

        //    modelBuilder.Entity<Content>()
        //        .HasOne(c => c.Writer)
        //        .WithMany(w => w.Contents)
        //        .HasForeignKey(c => c.WriterID)
        //        .OnDelete(DeleteBehavior.NoAction);

        //}

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Heading> Headings{ get; set; }
    }
}
