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
    internal class GioHangConfigurations : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.IDNV).IsRequired();
            builder.Property(c => c.IDKH).IsRequired();
            builder.Property(c => c.MaGH).HasColumnName("MaGH").HasColumnType("varchar(20)");
            builder.Property(c => c.SoLuong).HasColumnName("SoLuong").HasColumnType("Int");
            builder.Property(c => c.DonGia).HasColumnName("DonGia").HasColumnType("decimal");
            
            builder.HasOne(c => c.KhachHang).WithMany().HasForeignKey(c => c.IDKH);
            builder.HasOne(c => c.NhanVien).WithMany().HasForeignKey(c => c.IDNV);
        }
    }
}
