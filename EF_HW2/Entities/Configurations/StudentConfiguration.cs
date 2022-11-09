using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Entities.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.FirstName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(s => s.LastName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(s => s.BirthDate)
                   .IsRequired();

            builder.Property(s => s.PhoneNumber)
                   .IsRequired();

            builder.HasOne(s=>s.Card)
                   .WithOne(s=>s.Student)
                   .HasForeignKey<Card>(c=>c.SerialNumber);
            
        }
    }
}
