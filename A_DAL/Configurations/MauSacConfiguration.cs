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
    internal class MauSacConfiguration : IEntityTypeConfiguration<MauSac>
    {
        public void Configure(EntityTypeBuilder<MauSac> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.MaMau).HasColumnName("MaMau").HasColumnType("varchar(20)");
            builder.Property(c => c.Mau).HasColumnName("Mau").HasColumnType("nvarchar(20)");
        }
    }
}
