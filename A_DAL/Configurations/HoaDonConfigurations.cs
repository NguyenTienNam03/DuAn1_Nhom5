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
    internal class HoaDonConfigurations : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.IDKH).IsRequired();
            builder.Property(c =>c.IDNV).IsRequired();

            builder.Property(c => c.MaHD).HasColumnName("MaHD").HasColumnType("varchar(30)");
            builder.Property(c => c.DonGia).HasColumnName("DonGia").HasColumnType("decimal");
            builder.Property(c => c.SoLuong).HasColumnName("SoLuong").HasColumnType("Int");
            builder.Property(c => c.NgayTao).HasColumnName("NgayTao").HasColumnType("Datetime");
            builder.Property(c => c.TrangThai).HasColumnName("TrangThai").HasColumnType("nvarchar(100)");

            builder.HasOne(c => c.KhachHang).WithMany().HasForeignKey(c => c.IDKH);
            builder.HasOne(c => c.NhanVien).WithMany().HasForeignKey(c => c.IDNV);
        }
    }
}
