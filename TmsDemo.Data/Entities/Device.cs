using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmsDemo.Data.Entities
{
    public class Device
    {
        //Device ID
        public int Id { get; set; }

        //Device Lat coordinate
        public string Latitude { get; set; }

        //Device Long coordinate
        public string Longitude { get; set; }

        //Device green light duration measured in seconds
        public int Duration { get; set; }

        //Amount of cars needed to raise a "traffic" flag
        public int Threshold { get; set; }

        //Base constructor
        public Device()
        { }

        public Device(int id, string lat, string lon)
        {
            this.Id = id;
            this.Latitude = lat;
            this.Longitude = lon;
        }

        public Device(int id, string lat, string lon, int duration, int threshold)
        {
            this.Id = id;
            this.Latitude = lat;
            this.Longitude = lon;
            this.Duration = duration;
            this.Threshold = threshold;
        }
    }
}
