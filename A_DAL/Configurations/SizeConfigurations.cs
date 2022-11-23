using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class SizeConfigurations : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.MaSize).HasColumnName("MaSize").HasColumnType("varchar(20)");
            builder.Property(c => c.SoSize).HasColumnName("Size").HasColumnType("Int");

        }
    }
}
