using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TmsDemo.Data.Entities;

namespace TmsDemo.Web.ControllersWebAPI
{
    public class DevicesController : ApiController
    {
       private readonly Device[] _deviceList =  new Device[] 
       {
           new Device(1, "42.365858", "-71.185265", 10, 12, "light"),
           new Device(2, "42.366840", "-71.186621", 30, 48, "heavy"),
           new Device(3, "42.365212", "-71.184292", 45,782, "light"),
           new Device(4, "42.364443", "-71.185869", 10, 12, "medium"),
           new Device(5, "42.363298", "-71.186099", 30, 48, "heavy"),
           new Device(6, "42.367215", "-71.185110", 45,782, "light"),
           new Device(7, "42.366207", "-71.188701", 10, 12, "medium"),
           new Device(8, "42.365934", "-71.182985", 30, 48, "medium"),
           new Device(9, "42.366307", "-71.183886", 45,782, "medium"),
           new Device(10, "42.367101", "-71.182961", 30, 48, "heavy"),
           new Device(11, "42.367533", "-71.187737", 30, 48, "light"),
           new Device(12, "42.366101", "-71.187332", 30, 48, "heavy"),
           new Device(13, "42.366071", "-71.187161", 30, 48, "heavy"),
           new Device(14, "42.363998", "-71.189162", 30, 48, "light"),
           new Device(15, "42.363805", "-71.182907", 30, 48, "light")        
       };
        
    // GET: api/Devices
    public Object Get()
        {
            return new { Data = _deviceList };
            //return _deviceList;
        }
        
        // GET: api/Devices/5
        public Device Get(int id)
        {
            return _deviceList[id];
        }

        // POST: api/Devices
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Devices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Devices/5
        public void Delete(int id)
        {
        }
    }
}
