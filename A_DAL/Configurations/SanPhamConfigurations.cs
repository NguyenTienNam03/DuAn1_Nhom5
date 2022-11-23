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
    internal class SanPhamConfigurations : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.MaSP).HasColumnName("MaSP").HasColumnType("varchar(20)");
            builder.Property(x => x.TenSP).HasColumnName("TenSP").HasColumnType("varchar(100)");
        }
    }
}
