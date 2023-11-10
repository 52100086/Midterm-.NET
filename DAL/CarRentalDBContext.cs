using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CarRentalDBContext : DbContext
    {
        public DbSet<DonDatXe> DonDatXes { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<DonDatXe_TinhNang> DonDatXe_TinhNangs { get; set; }
        public DbSet<HangXe> HangXes { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiXe> LoaiXes { get; set; }
        public DbSet<MauXe> MauXes { get; set; }
        public DbSet<NhienLieu> NhienLieus { get; set; }
        public DbSet<TinhNangXe> TinhNangXes { get; set; }
        public DbSet<XeOto> XeOtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server='DESKTOP-ESFR26P';Database=CarRentalDB;Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonDatXe>()
                .HasKey(d => d.DonDatXeId);

            modelBuilder.Entity<DonDatXe>()
                .HasOne(d => d.KhachHang)
                .WithMany(kh => kh.DonDatXes)
                .HasForeignKey(d => d.KhachHangId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DonDatXe>()
                .HasOne(d => d.XeOto)
                .WithMany(x => x.DonDatXes)
                .HasForeignKey(d => d.XeOtoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DonDatXe>()
                .HasOne(d => d.NhienLieu)
                .WithMany(nl => nl.DonDatXes)
                .HasForeignKey(d => d.NhienLieuId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DonDatXe_TinhNang>()
                .HasKey(d => new { d.DonDatXeId, d.TinhNangId });

            modelBuilder.Entity<DonDatXe_TinhNang>()
                .HasOne(d => d.DonDatXe)
                .WithMany(d => d.DonDatXe_TinhNangs)
                .HasForeignKey(d => d.DonDatXeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DonDatXe_TinhNang>()
                .HasOne(d => d.TinhNangXe)
                .WithMany(t => t.DonDatXe_TinhNangs)
                .HasForeignKey(d => d.TinhNangId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HangXe>()
                .HasKey(h => h.HangXeId);

            modelBuilder.Entity<HangXe>()
                .HasMany(h => h.XeOtos)
                .WithOne(x => x.HangXe)
                .HasForeignKey(x => x.HangXeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<KhachHang>()
                .HasKey(kh => kh.KhachHangId);

            modelBuilder.Entity<KhachHang>()
                .HasMany(kh => kh.DonDatXes)
                .WithOne(d => d.KhachHang)
                .HasForeignKey(d => d.KhachHangId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LoaiXe>()
                .HasKey(lx => lx.LoaiXeId);

            modelBuilder.Entity<LoaiXe>()
                .HasMany(lx => lx.XeOtos)
                .WithOne(x => x.LoaiXe)
                .HasForeignKey(x => x.LoaiXeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MauXe>()
                .HasKey(mx => mx.MauXeId);

            modelBuilder.Entity<MauXe>()
                .HasMany(mx => mx.XeOtos)
                .WithOne(x => x.MauXe)
                .HasForeignKey(x => x.MauXeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NhienLieu>()
                .HasKey(nl => nl.NhienLieuId);

            modelBuilder.Entity<TinhNangXe>()
                .HasKey(tn => tn.TinhNangId);

            modelBuilder.Entity<TinhNangXe>()
                .HasMany(tn => tn.DonDatXe_TinhNangs)
                .WithOne(d => d.TinhNangXe)
                .HasForeignKey(d => d.TinhNangId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<XeOto>()
                .HasKey(x => x.XeOtoId);

            modelBuilder.Entity<XeOto>()
                .HasOne(x => x.LoaiXe)
                .WithMany(lx => lx.XeOtos)
                .HasForeignKey(x => x.LoaiXeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<XeOto>()
                .HasOne(x => x.HangXe)
                .WithMany(h => h.XeOtos)
                .HasForeignKey(x => x.HangXeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<XeOto>()
                .HasOne(x => x.MauXe)
                .WithMany(mx => mx.XeOtos)
                .HasForeignKey(x => x.MauXeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}