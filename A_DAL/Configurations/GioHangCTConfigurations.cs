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
    internal class GioHangCTConfigurations : IEntityTypeConfiguration<GioHangCT>
    {
        public void Configure(EntityTypeBuilder<GioHangCT> builder)
        {
            builder.HasKey(c => new {c.IDSP , c.IDGH} );
            builder.Property(c => c.DonGia).HasColumnName("DonGia").HasColumnType("decimal");
            builder.Property(c => c.SoLuong).HasColumnName("SoLuong").HasColumnType("Int");

            builder.HasOne(c => c.GioHang).WithMany().HasForeignKey(c => c.IDGH);
            builder.HasOne(c => c.ChiTietSanPham).WithMany().HasForeignKey(c => c.IDSP);

        }
    }
}
