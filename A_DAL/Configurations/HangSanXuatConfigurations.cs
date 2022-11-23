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
    internal class HangSanXuatConfigurations : IEntityTypeConfiguration<HangSanXuat>
    {
        public void Configure(EntityTypeBuilder<HangSanXuat> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.MaHangSX).HasColumnName("MaHangSX").HasColumnType("varchar(20)");
            builder.Property(c => c.TenHSX).HasColumnName("TenHangSX").HasColumnType("nvarchar(30)");

        }
    }
}
