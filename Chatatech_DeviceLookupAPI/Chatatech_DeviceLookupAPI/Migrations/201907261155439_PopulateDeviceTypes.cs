namespace Chatatech_DeviceLookupAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDeviceTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DeviceTypes (Name, Description, Active) VALUES(N'TV', N'Television', 1) ");
            Sql("INSERT INTO DeviceTypes (Name, Description, Active) VALUES(N'Washing Machine', N'Washing Machine', 1) ");
            Sql("INSERT INTO DeviceTypes (Name, Description, Active) VALUES(N'Dishwasher', N'Dishwasher', 1) ");
            Sql("INSERT INTO DeviceTypes (Name, Description, Active) VALUES(N'Fridge', N'Fridge', 1) ");
        }
        
        public override void Down()
        {
            Sql("Delete from DeviceTypes");
        }
    }
}
