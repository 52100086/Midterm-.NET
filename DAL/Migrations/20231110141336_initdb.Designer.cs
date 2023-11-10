﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(CarRentalDBContext))]
    [Migration("20231110141336_initdb")]
    partial class initdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DTO.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DTO.DonDatXe", b =>
                {
                    b.Property<int>("DonDatXeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonDatXeId"));

                    b.Property<double>("GiaThue")
                        .HasColumnType("float");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<int>("NhienLieuId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGianThue")
                        .HasColumnType("datetime2");

                    b.Property<double>("Thue")
                        .HasColumnType("float");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("XeOtoId")
                        .HasColumnType("int");

                    b.HasKey("DonDatXeId");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NhienLieuId");

                    b.HasIndex("XeOtoId");

                    b.ToTable("DonDatXes");
                });

            modelBuilder.Entity("DTO.DonDatXe_TinhNang", b =>
                {
                    b.Property<int>("DonDatXeId")
                        .HasColumnType("int");

                    b.Property<int>("TinhNangId")
                        .HasColumnType("int");

                    b.HasKey("DonDatXeId", "TinhNangId");

                    b.HasIndex("TinhNangId");

                    b.ToTable("DonDatXe_TinhNangs");
                });

            modelBuilder.Entity("DTO.HangXe", b =>
                {
                    b.Property<int>("HangXeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HangXeId"));

                    b.Property<string>("TenHangXe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HangXeId");

                    b.ToTable("HangXes");
                });

            modelBuilder.Entity("DTO.KhachHang", b =>
                {
                    b.Property<int>("KhachHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KhachHangId"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KhachHangId");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("DTO.LoaiXe", b =>
                {
                    b.Property<int>("LoaiXeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoaiXeId"));

                    b.Property<string>("TenLoaiXe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaiXeId");

                    b.ToTable("LoaiXes");
                });

            modelBuilder.Entity("DTO.MauXe", b =>
                {
                    b.Property<int>("MauXeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MauXeId"));

                    b.Property<string>("TenMauXe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MauXeId");

                    b.ToTable("MauXes");
                });

            modelBuilder.Entity("DTO.NhienLieu", b =>
                {
                    b.Property<int>("NhienLieuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NhienLieuId"));

                    b.Property<string>("NhienLieuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NhienLieuId");

                    b.ToTable("NhienLieus");
                });

            modelBuilder.Entity("DTO.TinhNangXe", b =>
                {
                    b.Property<int>("TinhNangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TinhNangId"));

                    b.Property<double>("GiaThue")
                        .HasColumnType("float");

                    b.Property<string>("TenTinhNang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TinhNangId");

                    b.ToTable("TinhNangXes");
                });

            modelBuilder.Entity("DTO.XeOto", b =>
                {
                    b.Property<int>("XeOtoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("XeOtoId"));

                    b.Property<double>("GiaThue")
                        .HasColumnType("float");

                    b.Property<int>("HangXeId")
                        .HasColumnType("int");

                    b.Property<int>("LoaiXeId")
                        .HasColumnType("int");

                    b.Property<int>("MauXeId")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("XeOtoId");

                    b.HasIndex("HangXeId");

                    b.HasIndex("LoaiXeId");

                    b.HasIndex("MauXeId");

                    b.ToTable("XeOtos");
                });

            modelBuilder.Entity("DTO.DonDatXe", b =>
                {
                    b.HasOne("DTO.KhachHang", "KhachHang")
                        .WithMany("DonDatXes")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DTO.NhienLieu", "NhienLieu")
                        .WithMany("DonDatXes")
                        .HasForeignKey("NhienLieuId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DTO.XeOto", "XeOto")
                        .WithMany("DonDatXes")
                        .HasForeignKey("XeOtoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhienLieu");

                    b.Navigation("XeOto");
                });

            modelBuilder.Entity("DTO.DonDatXe_TinhNang", b =>
                {
                    b.HasOne("DTO.DonDatXe", "DonDatXe")
                        .WithMany("DonDatXe_TinhNangs")
                        .HasForeignKey("DonDatXeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.TinhNangXe", "TinhNangXe")
                        .WithMany("DonDatXe_TinhNangs")
                        .HasForeignKey("TinhNangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonDatXe");

                    b.Navigation("TinhNangXe");
                });

            modelBuilder.Entity("DTO.XeOto", b =>
                {
                    b.HasOne("DTO.HangXe", "HangXe")
                        .WithMany("XeOtos")
                        .HasForeignKey("HangXeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DTO.LoaiXe", "LoaiXe")
                        .WithMany("XeOtos")
                        .HasForeignKey("LoaiXeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DTO.MauXe", "MauXe")
                        .WithMany("XeOtos")
                        .HasForeignKey("MauXeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("HangXe");

                    b.Navigation("LoaiXe");

                    b.Navigation("MauXe");
                });

            modelBuilder.Entity("DTO.DonDatXe", b =>
                {
                    b.Navigation("DonDatXe_TinhNangs");
                });

            modelBuilder.Entity("DTO.HangXe", b =>
                {
                    b.Navigation("XeOtos");
                });

            modelBuilder.Entity("DTO.KhachHang", b =>
                {
                    b.Navigation("DonDatXes");
                });

            modelBuilder.Entity("DTO.LoaiXe", b =>
                {
                    b.Navigation("XeOtos");
                });

            modelBuilder.Entity("DTO.MauXe", b =>
                {
                    b.Navigation("XeOtos");
                });

            modelBuilder.Entity("DTO.NhienLieu", b =>
                {
                    b.Navigation("DonDatXes");
                });

            modelBuilder.Entity("DTO.TinhNangXe", b =>
                {
                    b.Navigation("DonDatXe_TinhNangs");
                });

            modelBuilder.Entity("DTO.XeOto", b =>
                {
                    b.Navigation("DonDatXes");
                });
#pragma warning restore 612, 618
        }
    }
}