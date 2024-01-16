using System.Collections.Generic;
using System.Linq;
using Chatatech_DeviceLookup.Models;

namespace Chatatech_DeviceLookup.Classes
{
    public class QueryDeviceInfo
    {
        public static List<DeviceInfo> QueryForMatchingDeviceList(string Id, string manufacturer = "samsung")
        {
            string _Id = Id;
            if (Id.Length > 5) Id = Id.Substring(0, 5);
            DeviceEnquiry value;
            DeviceContext context = new DeviceContext();

            List<DeviceInfo> device = context.DeviceMatchings
                .Where(c => c.SerialMatch.Equals(Id) && c.DeviceBrand.Name.ToLower().Equals(manufacturer.ToLower()))
                .Select(c => new DeviceInfo()
                {
                    Model = c.Model,
                    SerialNumber = _Id,
                    Manufacturer = c.DeviceBrand.Name,
                    DeviceName = c.DeviceName.Name,
                    DeviceSize = c.DeviceName.Size,
                    YearofManufacter = c.YearOfManufacture,
                    OriginalCost = c.OriginalCost,
                    DeviceDescription = c.DeviceName.Description,
                    Type = c.DeviceType.Name,
                    Discontinued = c.Discontinued,
                    ReplacementDevices = new Replacement()
                    {
                        Model = c.ReplacementDevice.Model,
                        OriginalCost = c.ReplacementDevice.OriginalCost,
                        YearofManufacter = c.ReplacementDevice.YearOfManufacture,
                        DeviceDescription = c.ReplacementDevice.DeviceName.Description,
                        DeviceName = c.ReplacementDevice.DeviceName.Name,
                        Manufacturer = c.ReplacementDevice.DeviceBrand.Name,
                        DeviceSize = c.ReplacementDevice.DeviceName.Size
                    }
                })
                .ToList();
            return device;
        }
        public static DeviceInfo QueryForMatchingDevice(string Id, string manufacturer = "samsung")
        {
            string _Id = Id;
            if (Id.Length > 5) Id = Id.Substring(0, 5);
            DeviceContext context = new DeviceContext();

            DeviceInfo device = context.DeviceMatchings
                .Where(c => c.SerialMatch.Equals(Id) && c.DeviceBrand.Name.ToLower().Equals(manufacturer.ToLower()))
                .Select(c => new DeviceInfo()
                {
                    Model = c.Model,
                    SerialNumber = _Id,
                    Manufacturer = c.DeviceBrand.Name,
                    DeviceName = c.DeviceName.Name,
                    DeviceSize = c.DeviceName.Size,
                    YearofManufacter = c.YearOfManufacture,
                    OriginalCost = c.OriginalCost,
                    DeviceDescription = c.DeviceName.Description,
                    Type = c.DeviceType.Name,
                    Discontinued = c.Discontinued,
                    ReplacementDevices = new Replacement()
                    {
                        Model = c.ReplacementDevice.Model,
                        OriginalCost = c.ReplacementDevice.OriginalCost,
                        YearofManufacter = c.ReplacementDevice.YearOfManufacture,
                        DeviceDescription = c.ReplacementDevice.DeviceName.Description,
                        DeviceName = c.ReplacementDevice.DeviceName.Name,
                        Manufacturer = c.ReplacementDevice.DeviceBrand.Name,
                        DeviceSize = c.ReplacementDevice.DeviceName.Size
                    }
                })
                .SingleOrDefault();
            return device;
        }
    }
}