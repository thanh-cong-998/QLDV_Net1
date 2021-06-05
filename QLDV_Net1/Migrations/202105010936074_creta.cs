namespace QLDV_Net1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        IDAccount = c.Int(nullable: false, identity: true),
                        User = c.String(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.IDAccount);
            
            CreateTable(
                "dbo.ChiDoans",
                c => new
                    {
                        MaChiDoan = c.Int(nullable: false, identity: true),
                        TenChiDoan = c.String(),
                    })
                .PrimaryKey(t => t.MaChiDoan);
            
            CreateTable(
                "dbo.DoanViens",
                c => new
                    {
                        MaDoanVien = c.Int(nullable: false, identity: true),
                        TenDoanVien = c.String(nullable: false),
                        NgaySinh = c.String(),
                        QueQuan = c.String(),
                        GioiTinh = c.String(),
                        NgayVaoDoan = c.String(),
                        MaChiDoan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaDoanVien);
            
            CreateTable(
                "dbo.DiemDanhs",
                c => new
                    {
                        IDDiemDanh = c.Int(nullable: false, identity: true),
                        GhiChu = c.String(),
                        MaDoanVien = c.Int(nullable: false),
                        MaHoatDong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDDiemDanh);
            
            CreateTable(
                "dbo.HoatDongs",
                c => new
                    {
                        MaHoatDong = c.Int(nullable: false, identity: true),
                        TenHoatDong = c.String(),
                        ThoiGianToChuc = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.MaHoatDong);
            
            CreateTable(
                "dbo.XepLoais",
                c => new
                    {
                        IDXepLoai = c.Int(nullable: false, identity: true),
                        NamHoc = c.String(),
                        NhanXet = c.String(),
                        XepLoaiDoanVien = c.String(),
                        MaDoanVien = c.Int(nullable: false),
                        MaHoatDong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDXepLoai);
            
            CreateTable(
                "dbo.KhenThuongs",
                c => new
                    {
                        MaKhenThuong = c.Int(nullable: false, identity: true),
                        TenKhenThuong = c.String(),
                        ThanhTich = c.String(),
                        NamHoc = c.String(),
                        MaDoanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaKhenThuong);
            
            CreateTable(
                "dbo.DoanVienChiDoans",
                c => new
                    {
                        DoanVien_MaDoanVien = c.Int(nullable: false),
                        ChiDoan_MaChiDoan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DoanVien_MaDoanVien, t.ChiDoan_MaChiDoan })
                .ForeignKey("dbo.DoanViens", t => t.DoanVien_MaDoanVien, cascadeDelete: true)
                .ForeignKey("dbo.ChiDoans", t => t.ChiDoan_MaChiDoan, cascadeDelete: true)
                .Index(t => t.DoanVien_MaDoanVien)
                .Index(t => t.ChiDoan_MaChiDoan);
            
            CreateTable(
                "dbo.DiemDanhDoanViens",
                c => new
                    {
                        DiemDanh_IDDiemDanh = c.Int(nullable: false),
                        DoanVien_MaDoanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DiemDanh_IDDiemDanh, t.DoanVien_MaDoanVien })
                .ForeignKey("dbo.DiemDanhs", t => t.DiemDanh_IDDiemDanh, cascadeDelete: true)
                .ForeignKey("dbo.DoanViens", t => t.DoanVien_MaDoanVien, cascadeDelete: true)
                .Index(t => t.DiemDanh_IDDiemDanh)
                .Index(t => t.DoanVien_MaDoanVien);
            
            CreateTable(
                "dbo.HoatDongDiemDanhs",
                c => new
                    {
                        HoatDong_MaHoatDong = c.Int(nullable: false),
                        DiemDanh_IDDiemDanh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HoatDong_MaHoatDong, t.DiemDanh_IDDiemDanh })
                .ForeignKey("dbo.HoatDongs", t => t.HoatDong_MaHoatDong, cascadeDelete: true)
                .ForeignKey("dbo.DiemDanhs", t => t.DiemDanh_IDDiemDanh, cascadeDelete: true)
                .Index(t => t.HoatDong_MaHoatDong)
                .Index(t => t.DiemDanh_IDDiemDanh);
            
            CreateTable(
                "dbo.XepLoaiDoanViens",
                c => new
                    {
                        XepLoai_IDXepLoai = c.Int(nullable: false),
                        DoanVien_MaDoanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.XepLoai_IDXepLoai, t.DoanVien_MaDoanVien })
                .ForeignKey("dbo.XepLoais", t => t.XepLoai_IDXepLoai, cascadeDelete: true)
                .ForeignKey("dbo.DoanViens", t => t.DoanVien_MaDoanVien, cascadeDelete: true)
                .Index(t => t.XepLoai_IDXepLoai)
                .Index(t => t.DoanVien_MaDoanVien);
            
            CreateTable(
                "dbo.XepLoaiHoatDongs",
                c => new
                    {
                        XepLoai_IDXepLoai = c.Int(nullable: false),
                        HoatDong_MaHoatDong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.XepLoai_IDXepLoai, t.HoatDong_MaHoatDong })
                .ForeignKey("dbo.XepLoais", t => t.XepLoai_IDXepLoai, cascadeDelete: true)
                .ForeignKey("dbo.HoatDongs", t => t.HoatDong_MaHoatDong, cascadeDelete: true)
                .Index(t => t.XepLoai_IDXepLoai)
                .Index(t => t.HoatDong_MaHoatDong);
            
            CreateTable(
                "dbo.KhenThuongDoanViens",
                c => new
                    {
                        KhenThuong_MaKhenThuong = c.Int(nullable: false),
                        DoanVien_MaDoanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KhenThuong_MaKhenThuong, t.DoanVien_MaDoanVien })
                .ForeignKey("dbo.KhenThuongs", t => t.KhenThuong_MaKhenThuong, cascadeDelete: true)
                .ForeignKey("dbo.DoanViens", t => t.DoanVien_MaDoanVien, cascadeDelete: true)
                .Index(t => t.KhenThuong_MaKhenThuong)
                .Index(t => t.DoanVien_MaDoanVien);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KhenThuongDoanViens", "DoanVien_MaDoanVien", "dbo.DoanViens");
            DropForeignKey("dbo.KhenThuongDoanViens", "KhenThuong_MaKhenThuong", "dbo.KhenThuongs");
            DropForeignKey("dbo.XepLoaiHoatDongs", "HoatDong_MaHoatDong", "dbo.HoatDongs");
            DropForeignKey("dbo.XepLoaiHoatDongs", "XepLoai_IDXepLoai", "dbo.XepLoais");
            DropForeignKey("dbo.XepLoaiDoanViens", "DoanVien_MaDoanVien", "dbo.DoanViens");
            DropForeignKey("dbo.XepLoaiDoanViens", "XepLoai_IDXepLoai", "dbo.XepLoais");
            DropForeignKey("dbo.HoatDongDiemDanhs", "DiemDanh_IDDiemDanh", "dbo.DiemDanhs");
            DropForeignKey("dbo.HoatDongDiemDanhs", "HoatDong_MaHoatDong", "dbo.HoatDongs");
            DropForeignKey("dbo.DiemDanhDoanViens", "DoanVien_MaDoanVien", "dbo.DoanViens");
            DropForeignKey("dbo.DiemDanhDoanViens", "DiemDanh_IDDiemDanh", "dbo.DiemDanhs");
            DropForeignKey("dbo.DoanVienChiDoans", "ChiDoan_MaChiDoan", "dbo.ChiDoans");
            DropForeignKey("dbo.DoanVienChiDoans", "DoanVien_MaDoanVien", "dbo.DoanViens");
            DropIndex("dbo.KhenThuongDoanViens", new[] { "DoanVien_MaDoanVien" });
            DropIndex("dbo.KhenThuongDoanViens", new[] { "KhenThuong_MaKhenThuong" });
            DropIndex("dbo.XepLoaiHoatDongs", new[] { "HoatDong_MaHoatDong" });
            DropIndex("dbo.XepLoaiHoatDongs", new[] { "XepLoai_IDXepLoai" });
            DropIndex("dbo.XepLoaiDoanViens", new[] { "DoanVien_MaDoanVien" });
            DropIndex("dbo.XepLoaiDoanViens", new[] { "XepLoai_IDXepLoai" });
            DropIndex("dbo.HoatDongDiemDanhs", new[] { "DiemDanh_IDDiemDanh" });
            DropIndex("dbo.HoatDongDiemDanhs", new[] { "HoatDong_MaHoatDong" });
            DropIndex("dbo.DiemDanhDoanViens", new[] { "DoanVien_MaDoanVien" });
            DropIndex("dbo.DiemDanhDoanViens", new[] { "DiemDanh_IDDiemDanh" });
            DropIndex("dbo.DoanVienChiDoans", new[] { "ChiDoan_MaChiDoan" });
            DropIndex("dbo.DoanVienChiDoans", new[] { "DoanVien_MaDoanVien" });
            DropTable("dbo.KhenThuongDoanViens");
            DropTable("dbo.XepLoaiHoatDongs");
            DropTable("dbo.XepLoaiDoanViens");
            DropTable("dbo.HoatDongDiemDanhs");
            DropTable("dbo.DiemDanhDoanViens");
            DropTable("dbo.DoanVienChiDoans");
            DropTable("dbo.KhenThuongs");
            DropTable("dbo.XepLoais");
            DropTable("dbo.HoatDongs");
            DropTable("dbo.DiemDanhs");
            DropTable("dbo.DoanViens");
            DropTable("dbo.ChiDoans");
            DropTable("dbo.Accounts");
        }
    }
}
