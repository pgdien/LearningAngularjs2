using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearningAngularjs2.Models
{
    public class Video
    {
        public int id { get; set; }

        [StringLength(250)]
        public string title { get; set; }
        public string description { get; set; }
        public string link_video { get; set; }
        public string link_post { get; set; }
        public string note { get; set; }
    }
}