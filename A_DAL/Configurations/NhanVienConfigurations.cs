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
    internal class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.IDCV).IsRequired();
            
            builder.Property(x => x.MaNV).HasColumnName("MaNV").HasColumnType("varchar(20)");
            builder.Property(x => x.Ten).HasColumnName("Ten").HasColumnType("nvarchar(100)"); ;
            builder.Property(x => x.GioiTinh).HasColumnName("GioiTinh").HasColumnType("varchar(10)"); ;
            builder.Property(x => x.NgaySinh).HasColumnName("NgaySinh").HasColumnType("Datetime");
            builder.Property(x => x.SDT).HasColumnName("SDT").HasColumnType("varchar(30)"); ;
            builder.Property(x => x.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(100)"); ;
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("varchar(50)"); ;
            builder.Property(x => x.MatKhau).HasColumnName("MatKhau").HasColumnType("varchar(Max)"); ;
            builder.Property(x => x.TrangThai).HasColumnName("TrangThai").HasColumnType("nvarchar(100)"); ;
            

            builder.HasOne(x => x.ChucVu).WithMany().HasForeignKey(x => x.IDCV);
           
        }
    }
}
