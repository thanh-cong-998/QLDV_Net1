using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDV_Net1.DAL
{
    public partial class NetDbContext : DbContext
    {
        public NetDbContext()
            : base("name=NetDbContext")
        {
        }
        public virtual DbSet<DoanVien> DoanVien { get; set; }
        public virtual DbSet<ChiDoan> ChiDoan { get; set; }
        public virtual DbSet<XepLoai> XepLoai { get; set; }
        public virtual DbSet<HoatDong> HoatDong { get; set; }
        public virtual DbSet<KhenThuong> KhenThuong { get; set; }
        public virtual DbSet<DiemDanh> DiemDanh { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public int MaHoatDong { get; internal set; }
        public int MaDoanVien { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Data Source = DESKTOP - RLHQDCJ\SQLEXPRESS; Initial Catalog = QLDOANVIEN; Integrated Security = True
        }
    }
}
