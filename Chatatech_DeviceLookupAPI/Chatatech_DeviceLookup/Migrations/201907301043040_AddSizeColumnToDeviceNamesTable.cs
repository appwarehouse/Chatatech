namespace Chatatech_DeviceLookup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSizeColumnToDeviceNamesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeviceNames", "Size", c => c.String());
            Sql("Update DeviceNames set Size = Description, Description = '4K Smart TV' ");
        }
        
        public override void Down()
        {

            Sql("Update DeviceName set Description = Size ");
            DropColumn("dbo.DeviceNames", "Size");
        }
    }
}
