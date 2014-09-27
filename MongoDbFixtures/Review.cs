using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbFixtures
{
    public class Review
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string AddedByUserName { get; set; }
        public DateTime UTCAddedOn { get; set; }
    }
}