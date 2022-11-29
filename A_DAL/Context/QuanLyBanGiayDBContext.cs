using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Context
{
    public class QuanLyBanGiayDBContext : DbContext
    {
        public QuanLyBanGiayDBContext()
        {

        }
        public DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<HangSanXuat> hangSanXuats { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<MauSac> mausacs { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<HoaDonCT> hoaDonCTs { get; set; }
        public DbSet<GioHang> gioHangs { get; set; }
        public DbSet<GioHangCT> gioHangCTs { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }

        public QuanLyBanGiayDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            base.OnConfiguring(dbContextOptions.UseSqlServer("Data Source=WINDOWS-10;Initial Catalog=QLBG;User ID=tiennam;Password=12345;trusted_connection=true")); //SQL Nam
            //base.OnConfiguring(dbContextOptions.UseSqlServer("Data Source=DESKTOP-RPFD62E\\TRUONG;Initial Catalog=QLBG;Integrated Security=True")); //SQL Truong
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
