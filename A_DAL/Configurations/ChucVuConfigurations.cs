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
    internal class ChucVuConfigurations : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.MaCV).HasColumnName("MaCV").HasColumnType("varchar(20)");
            builder.Property(c => c.TenCV).HasColumnName("TenCV").HasColumnType("nvarchar(20)");
        }
    }
}
