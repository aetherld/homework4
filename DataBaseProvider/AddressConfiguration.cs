using ConsoleApp7.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.DataBaseProvider.Configurations
{
    public class Address : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Street").HasKey(b => b.Street);
            builder.Property(b => b.Street)
                .HasColumnName("Street")
                .IsRequired();
            builder.Property(b => b.City)
                .HasColumnName("City")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(b => b.Country)
                .HasColumnName("Country")
                .HasMaxLength(50)
                .IsRequired();
        }

    }
}
