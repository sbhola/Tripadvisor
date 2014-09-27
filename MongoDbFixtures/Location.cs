using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbFixtures
{
    public class Location
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}