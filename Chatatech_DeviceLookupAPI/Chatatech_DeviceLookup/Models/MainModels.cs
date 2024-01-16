using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Chatatech_DeviceLookup.Models
{

    public class ResponseObject
    {
        public string Message { get; set; }
        public int ResponseCode { get; set; }
        public Object ResponseData { get; set; }
    }

    public class APIUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class DeviceEnquiry
    {
        public string Make { get; set; }
        public string SerialNumber { get; set; }
    }

    public class DeviceInfo
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public double OriginalCost { get; set; }
        public string DeviceName { get; set; }
        public string DeviceSize { get; set; }
        public string DeviceDescription { get; set; }
        public string SerialNumber { get; set; }
        public int YearofManufacter { get; set; }
        public bool Discontinued { get; set; }
        public Replacement ReplacementDevices { get; set; }
       
    }

    public class Replacement
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double OriginalCost { get; set; }
        public string DeviceName { get; set; }
        public string DeviceSize { get; set; }
        public string DeviceDescription { get; set; }
        public string SerialNumber { get; set; }
        public int YearofManufacter { get; set; }
        public bool Discontinued { get; set; }
    }

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
        public string Size { get; set; }
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
        public bool Discontinued { get; set; }
        public virtual DeviceMatching ReplacementDevice { get; set; }
    }

    public class DeviceRequest
    {
        public int Id { get; set; }
        [Column(TypeName = "text")]
        public string IncomingRequest { get; set; }
        [Column(TypeName = "text")]
        public string OugoingResponse { get; set; }
        public DateTime DateAndTime { get; set; }
    }


    public class DeviceContext : DbContext
    {

        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<DeviceName> DeviceNames { get; set; }
        public DbSet<DeviceManufacturer> DeviceManufacturers { get; set; }
        public DbSet<DeviceMatching> DeviceMatchings { get; set; }
        public DbSet<DeviceRequest> DeviceRequests { get; set; }

        //public DbSet<DeviceReplacementDevice> DeviceReplacementDevices { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<DeviceMatching>()
        //        .
        //    base.OnModelCreating(modelBuilder);
        //}

        public DeviceContext()
            : base("name=conn")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DeviceContext, Migrations.Configuration>());
        }
    }
    public class MainModels
    {
    }
}