namespace Chatatech_DeviceLookup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiscontinuedToDeviceInfoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeviceMatchings", "Discontinued", c => c.Boolean(nullable: false, defaultValue: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DeviceMatchings", "Discontinued");
        }
    }
}
