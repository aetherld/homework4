using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.DataBaseProvider.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person").HasKey(b => b.Name);
            builder.Property(b => b.DoctorId)
                .HasColumnName("Name")
                .IsRequired();
            builder.Property(b => b.PhoneNumber)
                .HasColumnName("PhoneNubler")
                .IsRequired();
            builder.Property(b => b.EmailAddress)
                .HasColumnName("EmailAddress")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(b => b.DateBirth)
                .HasColumnName("DateBirth")
                .HasMaxLength(50)
                .IsRequired();
        }
    
    }
}
