using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Providers.Entities;
using Chatatech_DeviceLookup.Classes;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Chatatech_DeviceLookup.Models;
using Microsoft.AspNet.Identity;
using Chatatech_DeviceLookup.Filters;
using Newtonsoft.Json;

namespace Chatatech_DeviceLookup.API
{
    public class DeviceBySerialController : ApiController
    {

        // GET api/<controller>/5
        [JwtAuthentication]
        public HttpResponseMessage Get(string Serial)
        {

            //create new response Object
            ResponseObject responseObject = new ResponseObject();
            try
            {
                //get device Info from database
                var device = QueryDeviceInfo.QueryForMatchingDevice(Serial);
                //Save tracking info to database
                RequestTracking.SaveRequestTracking(Serial, JsonConvert.SerializeObject(device));

                //contruct response msg 
                return Request.CreateResponse(HttpStatusCode.OK, new ResponseObject()
                {
                    Message = device != null ? "Success" : "No device found",
                    ResponseCode = device != null ? 200 : 204,
                    ResponseData = device
                });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new ResponseObject()
                {
                    Message = "An error has occured. " + ex.Message.ToString(),
                    ResponseCode = 400,
                    ResponseData = null
                });

            }
        }
        
    }
}