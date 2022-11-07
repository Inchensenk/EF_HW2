using EF_HW2.Entities;
using EF_HW2.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2
{
    public class ApplicationContext : DbContext
    {
        private readonly StreamWriter logStream = new StreamWriter("mylog.txt", true);
        public DbSet<Card> Card { get; set; } = null!;
        public DbSet<Student> Student { get; set; } = null!;
        

        public ApplicationContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=s-dev-01;Database=StudentsDB;Trusted_Connection=True;");
            optionsBuilder.LogTo(logStream.WriteLine, LogLevel.Trace);//запись лога в файл

            //optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));//запись лога в дебагер

            //optionsBuilder.LogTo(System.Console.WriteLine);//запись лога в консоль
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new MarkConfiguration());
        }


        /*
          Для закрытия и утилизации файлового потока StreamWriter в классе контекста переопределены методы Dispose/DisposeAsync, 
          в которых вызывается метод Dispose/DisposeAsync объекта StreamWriter.
          В итоге при выполнении программы в папке приложения появится файл лога mylog.txt.*/
        //public override void Dispose()
        //{
        //    base.Dispose();
        //    logStream.Dispose();
        //}

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}
