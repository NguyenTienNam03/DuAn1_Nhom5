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
    internal class ChiTietSanPhamConfigurations : IEntityTypeConfiguration<ChiTietSanPham>
    {
        public void Configure(EntityTypeBuilder<ChiTietSanPham> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c => c.IDSP).IsRequired();
            builder.Property(c => c.IDHSX).IsRequired();
            builder.Property(c => c.IDSize).IsRequired();
            builder.Property(c => c.IDMauSac).IsRequired();
            builder.Property(c => c.MaSPCT).HasColumnName("MaSP").HasColumnType("nvarchar(20)");
            builder.Property(c => c.SoLuong).HasColumnName("SoLuong").HasColumnType("Int");
            builder.Property(c => c.Anh).HasColumnName("Anh").HasColumnType("varchar(50)");
          
            builder.Property(c => c.GiaNhap).HasColumnName("GiaNhap").HasColumnType("decimal");
            builder.Property(c => c.GiaBan).HasColumnName("GiaBan").HasColumnType("decimal");
            builder.Property(c => c.TrangThai).HasColumnName("TrangThai").HasColumnType("nvarchar(225)");

            builder.HasOne(c => c.mausac).WithMany().HasForeignKey(c => c.IDMauSac);
            builder.HasOne(c => c.SanPham).WithMany().HasForeignKey(c => c.IDSP);
            builder.HasOne(c => c.HangSanXuat).WithMany().HasForeignKey(c => c.IDHSX);
            builder.HasOne(c => c.size).WithMany().HasForeignKey(c => c.IDSize);

        }
    }
}
