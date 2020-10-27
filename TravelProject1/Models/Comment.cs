using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProject1.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string CommentInfo { get; set; }
        public DateTime CommentDate { get; set; }
        public virtual Post Post { get; set; }
        public int Status { get; set; }
        public int Rating { get; set; }
    }
}