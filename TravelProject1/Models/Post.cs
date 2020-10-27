using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProject1.Models
{
    public class Post
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public virtual Location location { get; set; }
        public virtual ICollection<Comment> comment { get; set; }
        public int Status { get; set; }
    }
}