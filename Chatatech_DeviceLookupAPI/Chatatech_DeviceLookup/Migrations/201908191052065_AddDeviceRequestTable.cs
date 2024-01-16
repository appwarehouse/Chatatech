namespace Chatatech_DeviceLookup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeviceRequestTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeviceRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncomingRequest = c.String(unicode: false, storeType: "text"),
                        OugoingResponse = c.String(unicode: false, storeType: "text"),
                        DateAndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DeviceRequests");
        }
    }
}
