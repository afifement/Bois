using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bois.Web.Models
{
    public class ProfileModels
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public virtual string Email { get; set; }

      
        [Display(Name = "Numéro de télephone")]
        public virtual string PhoneNumber { get; set; }

 
          [Display(Name = "Photo de profil")]
        public virtual HttpPostedFileBase Image { get; set; }
    }
}