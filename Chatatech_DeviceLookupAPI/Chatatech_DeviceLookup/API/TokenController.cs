using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Chatatech_DeviceLookup.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Chatatech_DeviceLookup.API
{
    public class TokenController : ApiController
    {
    
        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]APIUser value)
        {
            try
            {
                var userStore = new UserStore<IdentityUser>();
                var userManager = new UserManager<IdentityUser>(userStore);
                var user = userManager.Find(value.UserName, value.Password);

                if (user != null)
                {
                    //Generate jwt token 
                    var token = JwtManager.GenerateToken(value.UserName);
                    return Request.CreateResponse(HttpStatusCode.OK, new ResponseObject()
                    {
                        Message = "Success",
                        ResponseCode = 200,
                        ResponseData = token
                    });

                }
                else
                {
                    //invalid login credentials. Do not allow access
                    return Request.CreateResponse(HttpStatusCode.Forbidden, new ResponseObject()
                    {
                        Message = "Invalid login details",
                        ResponseCode = 403,
                        ResponseData = null
                    });
                }
            }
            catch (Exception ex)
            {
                //invalid login credentials. Do not allow access
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