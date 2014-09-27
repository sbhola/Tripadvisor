using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Runtime.Serialization;

namespace TripadvisorService
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public ObjectId Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public Location location { get; set; }
        
        [DataMember]
        public List<Review> Reviews;
    }
}