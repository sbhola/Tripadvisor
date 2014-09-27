using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace TripadvisorService
{
    [DataContract]
    public class Location
    {
        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public double Longitude { get; set; }

        [DataMember]
        public double Latitude { get; set; }
    }
}