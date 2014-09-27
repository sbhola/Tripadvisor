using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tripadvisor.Models
{
    public class Review
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string AddedByUserName { get; set; }
        public DateTime UTCAddedOn { get; set; }
    }
}