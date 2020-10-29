using MyTravelConsumer.TravelServiceReferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTravelConsumer.Models
{
    public class Place
    {
        public int id { get; set; }
        public string PlaceName { get; set; }
        public string PlaceAddress { get; set; }
        public string PlaceInfo { get; set; }
        public string UserID { get; set; }
        public int Status { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}