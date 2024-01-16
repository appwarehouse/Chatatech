using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Chatatech_DeviceLookup.Classes;
using Chatatech_DeviceLookup.Filters;
using Chatatech_DeviceLookup.Models;
using Newtonsoft.Json;

namespace Chatatech_DeviceLookup.API
{
    public class DeviceByMakeAndSerialController : ApiController
    {
        //// GET: api/DeviceByMakeAndSerial
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/DeviceByMakeAndSerial/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/DeviceByMakeAndSerial
        [JwtAuthentication]
        public HttpResponseMessage Post([FromBody]DeviceEnquiry value)
        {
            try
            {
                var Id = value.SerialNumber;
               

                //get matching devices
                var device = QueryDeviceInfo.QueryForMatchingDevice(Id, value.Make);
                //Save tracking info to database
                RequestTracking.SaveRequestTracking(value.SerialNumber, JsonConvert.SerializeObject(device));
                if (device != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, device);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "No device matched");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.OK, "An Error has Occured", ex);
            }
        }
    }
}
