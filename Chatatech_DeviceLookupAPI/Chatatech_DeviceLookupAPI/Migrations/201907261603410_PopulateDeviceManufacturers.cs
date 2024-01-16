namespace Chatatech_DeviceLookupAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateDeviceManufacturers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DeviceManufacturers (Name, Description, Active) VALUES('Samsung', 'Samsung', 1) ");
            Sql("INSERT INTO DeviceManufacturers (Name, Description, Active) VALUES('LG', 'LG', 1) ");
        }

        public override void Down()
        {
            Sql("Delete from DeviceManufacturers");
        }

    }
}
