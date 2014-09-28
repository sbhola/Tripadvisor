using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;


namespace ElasticSearchFixtures
{
    public class Hotel
    {
        public ObjectId Id { get; set; }      
        public string Name { get; set; }
        public int Rating { get; set; }
        public Location location { get; set; }
        public List<Review> Reviews;
    }
}