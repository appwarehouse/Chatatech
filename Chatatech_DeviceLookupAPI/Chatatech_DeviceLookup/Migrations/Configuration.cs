using Chatatech_DeviceLookup.Models;

namespace Chatatech_DeviceLookup.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chatatech_DeviceLookup.Models.DeviceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Chatatech_DeviceLookup.Models.DeviceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //INSERT INTO DeviceNames
            //    (Name, Description, Active, DeviceManufacturer_Id, DeviceType_Id)
            //VALUES('UHD', '40 Inch', 1, 1, 1)

            var deviceMan = context.DeviceManufacturers.Single(d => d.Id == 1);
            var deviceType = context.DeviceTypes.Single(d => d.Id == 1);
        context.DeviceNames.AddOrUpdate(a => new {a.Name, a.Size},

        new Models.DeviceName
                {
                    Name = "Undefined",
                    Size = "Undefined",
                    Description = "Undefined",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "32 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "40 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "43 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "46 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "48 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "49 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "50 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "55 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "58 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "60 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "65 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "65 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "70 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "75 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "UHD",
                    Size = "82 Inch",
                    Description = "4K Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "22 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "26 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "28 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "32 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "39 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "40 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "43 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "46 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "48 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "49 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "50 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "55 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "58 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "60 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "65 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "75 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "78 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "82 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "85 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "LED LCD",
                    Size = "88 Inch",
                    Description = "HD TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Plasma",
                    Size = "42 Inch",
                    Description = "Flat Screen TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Plasma",
                    Size = "43 Inch",
                    Description = "Flat Screen TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Plasma",
                    Size = "50 Inch",
                    Description = "Flat Screen TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Plasma",
                    Size = "51 Inch",
                    Description = "Flat Screen TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Plasma",
                    Size = "60 Inch",
                    Description = "Flat Screen TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Plasma",
                    Size = "64 Inch",
                    Description = "Flat Screen TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Q Series",
                    Size = "55 Inch",
                    Description = "QLED Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Q Series",
                    Size = "65 Inch",
                    Description = "QLED Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Q Series",
                    Size = "75 Inch",
                    Description = "QLED Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Q Series",
                    Size = "82 Inch",
                    Description = "QLED Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Q Series",
                    Size = "88 Inch",
                    Description = "QLED Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                },
                new Models.DeviceName
                {
                    Name = "Q Series",
                    Size = "98 Inch",
                    Description = "QLED Smart TV",
                    Active = true,
                    DeviceManufacturer = deviceMan,
                    DeviceType = deviceType
                }
                
                );

        }
    }
}
