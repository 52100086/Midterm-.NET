using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "HangXes",
                columns: table => new
                {
                    HangXeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHangXe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangXes", x => x.HangXeId);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    KhachHangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.KhachHangId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiXes",
                columns: table => new
                {
                    LoaiXeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiXe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiXes", x => x.LoaiXeId);
                });

            migrationBuilder.CreateTable(
                name: "MauXes",
                columns: table => new
                {
                    MauXeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMauXe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauXes", x => x.MauXeId);
                });

            migrationBuilder.CreateTable(
                name: "NhienLieus",
                columns: table => new
                {
                    NhienLieuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhienLieuName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhienLieus", x => x.NhienLieuId);
                });

            migrationBuilder.CreateTable(
                name: "TinhNangXes",
                columns: table => new
                {
                    TinhNangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinhNang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaThue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhNangXes", x => x.TinhNangId);
                });

            migrationBuilder.CreateTable(
                name: "XeOtos",
                columns: table => new
                {
                    XeOtoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaThue = table.Column<double>(type: "float", nullable: false),
                    LoaiXeId = table.Column<int>(type: "int", nullable: false),
                    HangXeId = table.Column<int>(type: "int", nullable: false),
                    MauXeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XeOtos", x => x.XeOtoId);
                    table.ForeignKey(
                        name: "FK_XeOtos_HangXes_HangXeId",
                        column: x => x.HangXeId,
                        principalTable: "HangXes",
                        principalColumn: "HangXeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_XeOtos_LoaiXes_LoaiXeId",
                        column: x => x.LoaiXeId,
                        principalTable: "LoaiXes",
                        principalColumn: "LoaiXeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_XeOtos_MauXes_MauXeId",
                        column: x => x.MauXeId,
                        principalTable: "MauXes",
                        principalColumn: "MauXeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DonDatXes",
                columns: table => new
                {
                    DonDatXeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangId = table.Column<int>(type: "int", nullable: false),
                    XeOtoId = table.Column<int>(type: "int", nullable: false),
                    GiaThue = table.Column<double>(type: "float", nullable: false),
                    Thue = table.Column<double>(type: "float", nullable: false),
                    TongCong = table.Column<double>(type: "float", nullable: false),
                    NhienLieuId = table.Column<int>(type: "int", nullable: false),
                    ThoiGianThue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonDatXes", x => x.DonDatXeId);
                    table.ForeignKey(
                        name: "FK_DonDatXes_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "KhachHangId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonDatXes_NhienLieus_NhienLieuId",
                        column: x => x.NhienLieuId,
                        principalTable: "NhienLieus",
                        principalColumn: "NhienLieuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonDatXes_XeOtos_XeOtoId",
                        column: x => x.XeOtoId,
                        principalTable: "XeOtos",
                        principalColumn: "XeOtoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DonDatXe_TinhNangs",
                columns: table => new
                {
                    DonDatXeId = table.Column<int>(type: "int", nullable: false),
                    TinhNangId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonDatXe_TinhNangs", x => new { x.DonDatXeId, x.TinhNangId });
                    table.ForeignKey(
                        name: "FK_DonDatXe_TinhNangs_DonDatXes_DonDatXeId",
                        column: x => x.DonDatXeId,
                        principalTable: "DonDatXes",
                        principalColumn: "DonDatXeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonDatXe_TinhNangs_TinhNangXes_TinhNangId",
                        column: x => x.TinhNangId,
                        principalTable: "TinhNangXes",
                        principalColumn: "TinhNangId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonDatXe_TinhNangs_TinhNangId",
                table: "DonDatXe_TinhNangs",
                column: "TinhNangId");

            migrationBuilder.CreateIndex(
                name: "IX_DonDatXes_KhachHangId",
                table: "DonDatXes",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_DonDatXes_NhienLieuId",
                table: "DonDatXes",
                column: "NhienLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_DonDatXes_XeOtoId",
                table: "DonDatXes",
                column: "XeOtoId");

            migrationBuilder.CreateIndex(
                name: "IX_XeOtos_HangXeId",
                table: "XeOtos",
                column: "HangXeId");

            migrationBuilder.CreateIndex(
                name: "IX_XeOtos_LoaiXeId",
                table: "XeOtos",
                column: "LoaiXeId");

            migrationBuilder.CreateIndex(
                name: "IX_XeOtos_MauXeId",
                table: "XeOtos",
                column: "MauXeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "DonDatXe_TinhNangs");

            migrationBuilder.DropTable(
                name: "DonDatXes");

            migrationBuilder.DropTable(
                name: "TinhNangXes");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhienLieus");

            migrationBuilder.DropTable(
                name: "XeOtos");

            migrationBuilder.DropTable(
                name: "HangXes");

            migrationBuilder.DropTable(
                name: "LoaiXes");

            migrationBuilder.DropTable(
                name: "MauXes");
        }
    }
}
