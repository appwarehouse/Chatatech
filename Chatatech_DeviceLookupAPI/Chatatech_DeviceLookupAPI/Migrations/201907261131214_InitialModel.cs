namespace Chatatech_DeviceLookupAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeviceManufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeviceMatchings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SerialMatch = c.String(),
                        Model = c.String(),
                        YearOfManufacture = c.Int(nullable: false),
                        OriginalCost = c.Double(nullable: false),
                        DeviceBrand_Id = c.Int(),
                        DeviceName_Id = c.Int(),
                        DeviceType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceManufacturers", t => t.DeviceBrand_Id)
                .ForeignKey("dbo.DeviceNames", t => t.DeviceName_Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .Index(t => t.DeviceBrand_Id)
                .Index(t => t.DeviceName_Id)
                .Index(t => t.DeviceType_Id);
            
            CreateTable(
                "dbo.DeviceNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        DeviceManufacturer_Id = c.Int(),
                        DeviceType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceManufacturers", t => t.DeviceManufacturer_Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .Index(t => t.DeviceManufacturer_Id)
                .Index(t => t.DeviceType_Id);
            
            CreateTable(
                "dbo.DeviceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeviceMatchings", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.DeviceMatchings", "DeviceName_Id", "dbo.DeviceNames");
            DropForeignKey("dbo.DeviceNames", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.DeviceNames", "DeviceManufacturer_Id", "dbo.DeviceManufacturers");
            DropForeignKey("dbo.DeviceMatchings", "DeviceBrand_Id", "dbo.DeviceManufacturers");
            DropIndex("dbo.DeviceNames", new[] { "DeviceType_Id" });
            DropIndex("dbo.DeviceNames", new[] { "DeviceManufacturer_Id" });
            DropIndex("dbo.DeviceMatchings", new[] { "DeviceType_Id" });
            DropIndex("dbo.DeviceMatchings", new[] { "DeviceName_Id" });
            DropIndex("dbo.DeviceMatchings", new[] { "DeviceBrand_Id" });
            DropTable("dbo.DeviceTypes");
            DropTable("dbo.DeviceNames");
            DropTable("dbo.DeviceMatchings");
            DropTable("dbo.DeviceManufacturers");
        }
    }
}
