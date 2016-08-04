using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearningAngularjs2.Models
{
    public class User
    {
        public User()
        {
            webpages_Roles = new HashSet<webpages_Roles>();
        }

        public int UserId { get; set; }

        [Required]
        [StringLength(56)]
        public string Username { get; set; }
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}