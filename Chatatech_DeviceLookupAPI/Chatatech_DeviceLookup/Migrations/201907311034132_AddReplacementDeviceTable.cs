namespace Chatatech_DeviceLookup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReplacementDeviceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeviceMatchings", "ReplacementDevice_Id", c => c.Int());
            CreateIndex("dbo.DeviceMatchings", "ReplacementDevice_Id");
            AddForeignKey("dbo.DeviceMatchings", "ReplacementDevice_Id", "dbo.DeviceMatchings", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeviceMatchings", "ReplacementDevice_Id", "dbo.DeviceMatchings");
            DropIndex("dbo.DeviceMatchings", new[] { "ReplacementDevice_Id" });
            DropColumn("dbo.DeviceMatchings", "ReplacementDevice_Id");
        }
    }
}
