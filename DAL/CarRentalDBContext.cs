using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CarRentalDBContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<LoaiXe> LoaiXes { get; set; }
        public DbSet<XeOto> XeOtos { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<DonDatXe> DonDatXes { get; set; }
        public DbSet<TinhNangXe> TinhNangXes { get; set; }
        public DbSet<DonDatXe_TinhNang> DonDatXe_TinhNangs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CarRentalDB;Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                            .HasKey(a => a.AccountId);

            modelBuilder.Entity<LoaiXe>()
                .HasKey(l => l.LoaiXeId);

            modelBuilder.Entity<XeOto>()
                .HasKey(x => x.XeOtoId);

            modelBuilder.Entity<KhachHang>()
                .HasKey(k => k.KhachHangId);

            modelBuilder.Entity<DonDatXe>()
                .HasKey(d => d.DonDatXeId);

            modelBuilder.Entity<TinhNangXe>()
                .HasKey(t => t.TinhNangId);
                
            modelBuilder.Entity<DonDatXe_TinhNang>()
                .HasKey(d => new { d.DonDatXeId, d.TinhNangId });



            // Define relationships
            modelBuilder.Entity<XeOto>()
                .HasOne(x => x.LoaiXe)
                .WithMany(l => l.XeOtos)
                .HasForeignKey(x => x.LoaiXeId);

            modelBuilder.Entity<DonDatXe>()
                .HasOne(d => d.KhachHang)
                .WithMany(k => k.DonDatXes)
                .HasForeignKey(d => d.KhachHangId);

            modelBuilder.Entity<DonDatXe>()
                .HasOne(d => d.XeOto)
                .WithMany(x => x.DonDatXes)
                .HasForeignKey(d => d.XeOtoId);

            modelBuilder.Entity<DonDatXe_TinhNang>()
                .HasOne(d => d.DonDatXe)
                .WithMany(d => d.DonDatXe_TinhNangs)
                .HasForeignKey(d => d.DonDatXeId);

            modelBuilder.Entity<DonDatXe_TinhNang>()
                .HasOne(d => d.TinhNangXe)
                .WithMany(t => t.DonDatXe_TinhNangs)
                .HasForeignKey(d => d.TinhNangId);

            modelBuilder.Entity<DonDatXe>()
                        .Property(d => d.GiaThue)
                        .HasColumnType("decimal(18, 2)");


            modelBuilder.Entity<XeOto>()
                        .Property(d => d.GiaThue)
                        .HasColumnType("decimal(18, 2)");
        }
    }
}