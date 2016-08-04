using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearningAngularjs2.Models
{
    public class webpages_Roles
    {
        public webpages_Roles()
        {
            User = new HashSet<User>();
        }

        [Key]
        public int RoleId { get; set; }
        [Required]
        [StringLength(256)]
        public string RoleName { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}