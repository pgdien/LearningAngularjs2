using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearningAngularjs2.Models
{
    public class Banner
    {
        public int id { get; set; }
        [StringLength(250)]
        public string title { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        [StringLength(20)]
        public string text_link { get; set; }
        public string image { get; set; }
        public string ghichu { get; set; }
    }
}