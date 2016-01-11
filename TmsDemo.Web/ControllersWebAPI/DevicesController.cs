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
       private readonly Device[] _deviceList =  new Device[] { new Device(1,"",""), new Device(2,"","")};

    // GET: api/Devices
    public IEnumerable<Device> Get()
        {
            return _deviceList;
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
