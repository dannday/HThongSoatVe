namespace HThongSoatVe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editVe1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuongTrinh",
                c => new
                    {
                        id_chuongtrinh = c.Int(nullable: false),
                        ten = c.String(maxLength: 50, unicode: false),
                        diadiem = c.String(maxLength: 50, unicode: false),
                        mota = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id_chuongtrinh);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        id_khachhang = c.Int(nullable: false),
                        ten = c.String(maxLength: 10, fixedLength: true),
                        cccd = c.Int(),
                        ngaysinh = c.DateTime(storeType: "date"),
                        id_ve = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.id_khachhang);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        id_nhanvien = c.Int(nullable: false),
                        sdt = c.String(maxLength: 50),
                        pass = c.String(maxLength: 50),
                        tennhanvien = c.String(maxLength: 50),
                        phanquyen = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_nhanvien);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.Ve",
                c => new
                    {
                        id_ve = c.Int(nullable: false),
                        loai = c.String(maxLength: 50, unicode: false),
                        gia = c.String(maxLength: 50, unicode: false),
                        ngaysk = c.DateTime(storeType: "date"),
                        soluong = c.Int(),
                        QRcode = c.String(maxLength: 50, unicode: false),
                        ChuongTrinh_id_chuongtrinh = c.Int(),
                    })
                .PrimaryKey(t => t.id_ve)
                .ForeignKey("dbo.ChuongTrinh", t => t.ChuongTrinh_id_chuongtrinh)
                .Index(t => t.ChuongTrinh_id_chuongtrinh);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ve", "ChuongTrinh_id_chuongtrinh", "dbo.ChuongTrinh");
            DropIndex("dbo.Ve", new[] { "ChuongTrinh_id_chuongtrinh" });
            DropTable("dbo.Ve");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.NhanVien");
            DropTable("dbo.KhachHang");
            DropTable("dbo.ChuongTrinh");
        }
    }
}
 