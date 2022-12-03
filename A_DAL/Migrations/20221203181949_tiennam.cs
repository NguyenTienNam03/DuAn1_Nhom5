using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class tiennam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chucVus",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCV = table.Column<string>(type: "varchar(20)", nullable: true),
                    TenCV = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "hangSanXuats",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHangSX = table.Column<string>(type: "varchar(20)", nullable: true),
                    TenHangSX = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangSanXuats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKH = table.Column<string>(type: "varchar(20)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "mausacs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaMau = table.Column<string>(type: "varchar(20)", nullable: true),
                    Mau = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mausacs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSP = table.Column<string>(type: "varchar(20)", nullable: true),
                    TenSP = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSize = table.Column<string>(type: "varchar(20)", nullable: true),
                    Size = table.Column<int>(type: "Int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNV = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "Datetime", nullable: true),
                    GioiTinh = table.Column<string>(type: "varchar(10)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SDT = table.Column<string>(type: "varchar(30)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true),
                    MatKhau = table.Column<string>(type: "varchar(Max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_nhanViens_chucVus_IDCV",
                        column: x => x.IDCV,
                        principalTable: "chucVus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSanPhams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    SoLuong = table.Column<int>(type: "Int", nullable: false),
                    Anh = table.Column<string>(type: "varchar(50)", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal", nullable: true),
                    GiaBan = table.Column<decimal>(type: "decimal", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(225)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPhams_hangSanXuats_IDHSX",
                        column: x => x.IDHSX,
                        principalTable: "hangSanXuats",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPhams_mausacs_IDMauSac",
                        column: x => x.IDMauSac,
                        principalTable: "mausacs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPhams_sanPhams_IDSP",
                        column: x => x.IDSP,
                        principalTable: "sanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPhams_sizes_IDSize",
                        column: x => x.IDSize,
                        principalTable: "sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGH = table.Column<string>(type: "varchar(20)", nullable: true),
                    SoLuong = table.Column<int>(type: "Int", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_gioHangs_khachHangs_IDKH",
                        column: x => x.IDKH,
                        principalTable: "khachHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gioHangs_nhanViens_IDNV",
                        column: x => x.IDNV,
                        principalTable: "nhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "varchar(30)", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: true),
                    SoLuong = table.Column<int>(type: "Int", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "Datetime", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_IDKH",
                        column: x => x.IDKH,
                        principalTable: "khachHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_IDNV",
                        column: x => x.IDNV,
                        principalTable: "nhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangCTs",
                columns: table => new
                {
                    IDSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: true),
                    SoLuong = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangCTs", x => new { x.IDSP, x.IDGH });
                    table.ForeignKey(
                        name: "FK_gioHangCTs_ChiTietSanPhams_IDSP",
                        column: x => x.IDSP,
                        principalTable: "ChiTietSanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gioHangCTs_gioHangs_IDGH",
                        column: x => x.IDGH,
                        principalTable: "gioHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonCTs",
                columns: table => new
                {
                    IDSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: true),
                    SoLuong = table.Column<int>(type: "Int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonCTs", x => new { x.IDSP, x.IDHD });
                    table.ForeignKey(
                        name: "FK_hoaDonCTs_ChiTietSanPhams_IDSP",
                        column: x => x.IDSP,
                        principalTable: "ChiTietSanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonCTs_hoaDons_IDHD",
                        column: x => x.IDHD,
                        principalTable: "hoaDons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPhams_IDHSX",
                table: "ChiTietSanPhams",
                column: "IDHSX");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPhams_IDMauSac",
                table: "ChiTietSanPhams",
                column: "IDMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPhams_IDSize",
                table: "ChiTietSanPhams",
                column: "IDSize");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPhams_IDSP",
                table: "ChiTietSanPhams",
                column: "IDSP");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangCTs_IDGH",
                table: "gioHangCTs",
                column: "IDGH");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_IDKH",
                table: "gioHangs",
                column: "IDKH");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_IDNV",
                table: "gioHangs",
                column: "IDNV");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonCTs_IDHD",
                table: "hoaDonCTs",
                column: "IDHD");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_IDKH",
                table: "hoaDons",
                column: "IDKH");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_IDNV",
                table: "hoaDons",
                column: "IDNV");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_IDCV",
                table: "nhanViens",
                column: "IDCV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gioHangCTs");

            migrationBuilder.DropTable(
                name: "hoaDonCTs");

            migrationBuilder.DropTable(
                name: "gioHangs");

            migrationBuilder.DropTable(
                name: "ChiTietSanPhams");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "hangSanXuats");

            migrationBuilder.DropTable(
                name: "mausacs");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "chucVus");
        }
    }
}
