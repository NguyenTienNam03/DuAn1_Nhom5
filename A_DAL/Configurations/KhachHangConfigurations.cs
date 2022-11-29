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
    internal class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(c => c.Ten).HasColumnName("Ten").HasColumnType("nvarchar(100)");
            builder.Property(c => c.MaKH).HasColumnName("MaKH").HasColumnType("varchar(20)");
            builder.Property(c => c.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(100)");
            builder.Property(c => c.SDT).HasColumnName("SDT").HasColumnType("nvarchar(10)");
        }
    }
}
