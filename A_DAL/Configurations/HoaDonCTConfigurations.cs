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
    internal class HoaDonCTConfigurations : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.HasKey(c => new { c.IDSP, c.IDHD });

            builder.Property(c => c.DonGia).HasColumnName("DonGia").HasColumnType("decimal");
            builder.Property(c => c.SoLuong).HasColumnName("SoLuong").HasColumnType("Int");

            builder.HasOne(c => c.HoaDon).WithMany().HasForeignKey(c => c.IDHD);
            builder.HasOne(c => c.ChiTietSanPham).WithMany().HasForeignKey(c => c.IDSP);
        }
    }
}
