using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<Student> Student { get; set; }
        public ApplicationContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PIXEL;Database=StudentsDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasKey(c => c.Id);
            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            //modelBuilder.Entity<Student>().HasOne(s => s.Student).WithOne(c=>c.Card)
        }
    }
}
