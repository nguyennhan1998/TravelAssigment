using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProject1.Models
{
    public class Location
    {
        public int id { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public string LocationDescription { get; set; }
        public int Status { get; set; }
    }
}