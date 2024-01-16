using System;
using System.Collections.Generic;
using Chatatech_DeviceLookup.Models;

namespace Chatatech_DeviceLookup.Classes
{
    public class RequestTracking
    {
        public static void SaveRequestTracking(string serialNumber, string responseString)
        {
            try
            {
                DeviceContext context = new DeviceContext();

                //save request to database

                context.DeviceRequests.Add(new DeviceRequest()
                {
                    DateAndTime = DateTime.Now,
                    IncomingRequest = serialNumber,
                    OugoingResponse = responseString
                });

                //save the chnages to database
                context.SaveChanges();
            }
            catch (Exception)
            {
            }
        }
    }
}