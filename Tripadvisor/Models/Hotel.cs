using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tripadvisor.Models
{
    public class Hotel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public Location location { get; set; }
        public List<Review> Reviews;
    }
}