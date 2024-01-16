namespace Chatatech_DeviceLookup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDeviceNames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DeviceNames (Name, Description, Active, DeviceManufacturer_Id, DeviceType_Id) VALUES('UHD', '40 Inch', 1, 1, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
