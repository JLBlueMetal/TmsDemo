using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TmsDemo.Data.Entities;

namespace TmsDemo.Test
{
    [TestClass]
    public class TmsDemoTests
    {
        [TestMethod]
        public void Device_Class_Test()
        {
            Device d1 = new Device();

            d1.Id = 4;
            d1.Latitude = "89";
            d1.Longitude = "89";

            Device d2 = new Device(1, "lat", "long");
            d2.Duration = 4;
            d2.Threshold = 25;
            d2.Latitude = "new lat";
            d2.Longitude = "";

            Device d3 = new Device(1, "lat", "long", 10, 12, "light");
            d3.Duration = 55;
            d3.Id = 23;

        }
        
    }
}
