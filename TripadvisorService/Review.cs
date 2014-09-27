using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace TripadvisorService
{
    [DataContract]
    public class Review
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public string AddedByUserName { get; set; }

        [DataMember]
        public DateTime UTCAddedOn { get; set; }
    }
}