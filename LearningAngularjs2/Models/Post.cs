using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearningAngularjs2.Models
{
    public class Post
    {
        [Key]
        public int idPost { get; set; }
        public int idCategory { get; set; }
        [StringLength(50)]
        public string idUserCreated { get; set; }
        [StringLength(50)]
        public string idUserModified { get; set; }
        public DateTime? timeCreated { get; set; }
        public DateTime? timeModified { get; set; }
        [StringLength(500)]
        public string title { get; set; }
        public string alias { get; set; }
        public string content { get; set; }
        public string note { get; set; }
        [StringLength(1000)]
        public string description { get; set; }
        public int? published { get; set; }
        public string image { get; set; }
        public string tags { get; set; }
        [StringLength(50)]
        public string version { get; set; }
        public int? deleted { get; set; }
        public int? featured { get; set; }
        public string metadescription { get; set; }
        public string metakewords { get; set; }
        [StringLength(50)]
        public string author { get; set; }
        [StringLength(50)]
        public string robots { get; set; }
    }
}