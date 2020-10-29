using MyTravelConsumer.TravelServiceReferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTravelConsumer.Models
{
    public class Image
    {
        public int id { get; set; }
        public string ImageURL { get; set; }
        public int PlaceID { get; set; }
        public string UserID { get; set; }
        public int Status { get; set; }
        public virtual Place Place { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}