using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HThongSoatVe.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<ChuongTrinh> ChuongTrinhs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuongTrinh>()
                .Property(e => e.ten)
                .IsUnicode(false);

            modelBuilder.Entity<ChuongTrinh>()
                .Property(e => e.diadiem)
                .IsUnicode(false);

            modelBuilder.Entity<ChuongTrinh>()
                .Property(e => e.mota)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.ten)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.id_ve)
                .IsFixedLength();

            modelBuilder.Entity<Ve>()
                .Property(e => e.loai)
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.gia)
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.QRcode)
                .IsUnicode(false);
        }
    }
}
