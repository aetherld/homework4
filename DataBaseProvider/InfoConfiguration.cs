using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.DataBaseProvider.Configurations
{
    public class InfoConfiguration : IEntityTypeConfiguration<Info>
    {
        public void Configure(EntityTypeBuilder<Infot> builder)
        {
            builder.ToTable("StudentNumber").HasKey(b => b.StudentNumber);
            builder.Property(b => b.PatientId)
                .HasColumnName("StudentNumber")
                .IsRequired();
 
        }

    }
}
