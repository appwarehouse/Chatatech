using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Chatatech_DeviceLookupAPI.Models
{

    public class DeviceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }

    public class DeviceManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }

    public class DeviceName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeviceManufacturer DeviceManufacturer { get; set; }
        public DeviceType DeviceType { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }

    public class DeviceMatching
    {
        public int Id { get; set; }
        public string SerialMatch { get; set; }
        public string Model { get; set; }
        public DeviceType DeviceType { get; set; }
        public DeviceManufacturer DeviceBrand { get; set; }
        public DeviceName DeviceName { get; set; }
        public int YearOfManufacture { get; set; }
        public double OriginalCost { get; set; }
    }

    //public class DeviceReplacementDevice
    //{
    //    [Key, Column(Order = 0)]
    //    public DeviceMatching OriginalDevice { get; set; }
    //    [Key, Column(Order = 1)]
    //    public DeviceMatching ReplacementDevice { get; set; }
    //}



    public class DeviceContext : DbContext
    {

        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<DeviceName> DeviceNames { get; set; }
        public DbSet<DeviceManufacturer> DeviceManufacturers { get; set; }
        public DbSet<DeviceMatching> DeviceMatchings { get; set; }
        //public DbSet<DeviceReplacementDevice> DeviceReplacementDevices { get; set; }

        public DeviceContext()
            : base("name=conn")
        {
            
        }
    }
    public class MainModels
    {
    }
}