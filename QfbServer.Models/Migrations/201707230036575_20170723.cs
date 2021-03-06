namespace QfbServer.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20170723 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MeasureDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PointId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        ProjectName = c.String(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(nullable: false),
                        TargetId = c.Int(nullable: false),
                        TargetName = c.String(nullable: false),
                        TargetType = c.String(),
                        PageId = c.Int(nullable: false),
                        MeasurePoint = c.String(),
                        Direction = c.String(),
                        UpperTolerance = c.String(),
                        LowerTolerance = c.String(),
                        Value1 = c.String(),
                        Value2 = c.String(),
                        Value3 = c.String(),
                        Value4 = c.String(),
                        Value5 = c.String(),
                        Value6 = c.String(),
                        Value7 = c.String(),
                        Value8 = c.String(),
                        Value9 = c.String(),
                        Value10 = c.String(),
                        Username = c.String(nullable: false),
                        Timestamp = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MeasurementItems",
                c => new
                    {
                        MeasItemID = c.Int(nullable: false, identity: true),
                        MeasReportID = c.Int(nullable: false),
                        MeasItemNO = c.String(),
                        MeasItemName = c.String(),
                        Remark1 = c.Int(),
                        Remark2 = c.String(),
                        Remark3 = c.String(),
                    })
                .PrimaryKey(t => t.MeasItemID);
            
            CreateTable(
                "dbo.MeasurementPages",
                c => new
                    {
                        MeasPageID = c.Int(nullable: false, identity: true),
                        MeasItemID = c.Int(nullable: false),
                        MeasPageNo = c.String(),
                        MeasPageImage = c.String(),
                        Remark1 = c.Int(),
                        Remark2 = c.String(),
                        Remark3 = c.String(),
                    })
                .PrimaryKey(t => t.MeasPageID);
            
            CreateTable(
                "dbo.MeasurementPoints",
                c => new
                    {
                        MeasPointID = c.Int(nullable: false, identity: true),
                        MeasPageID = c.Int(nullable: false),
                        PointNo = c.String(),
                        PointType = c.String(),
                        XAxis = c.String(),
                        YAxis = c.String(),
                        ZAxis = c.String(),
                        UpperTol = c.String(),
                        LowerTol = c.String(),
                        Direct = c.String(),
                        AVG = c.String(),
                        CorrectDirect = c.String(),
                        Remark1 = c.Int(),
                        Remark2 = c.String(),
                        Remark3 = c.String(),
                    })
                .PrimaryKey(t => t.MeasPointID);
            
            CreateTable(
                "dbo.MeasurementReports",
                c => new
                    {
                        MeasReportID = c.Int(nullable: false, identity: true),
                        ProjectNo = c.String(),
                        PartNo = c.String(),
                        PartName = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        Creator = c.String(),
                        Remark1 = c.Int(),
                        Remark2 = c.String(),
                        Remark3 = c.String(),
                    })
                .PrimaryKey(t => t.MeasReportID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PageName = c.String(nullable: false),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(nullable: false),
                        ProductName = c.String(nullable: false),
                        TargetName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        userType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warnings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        Filed1 = c.String(),
                        Filed2 = c.String(),
                        WarningType = c.String(),
                        PreWwarningTime = c.DateTime(nullable: false),
                        DoTime = c.DateTime(),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "Project_Id", "dbo.Projects");
            DropIndex("dbo.Pages", new[] { "Project_Id" });
            DropTable("dbo.Warnings");
            DropTable("dbo.Users");
            DropTable("dbo.Projects");
            DropTable("dbo.Pages");
            DropTable("dbo.MeasurementReports");
            DropTable("dbo.MeasurementPoints");
            DropTable("dbo.MeasurementPages");
            DropTable("dbo.MeasurementItems");
            DropTable("dbo.MeasureDatas");
        }
    }
}
