using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bois.Web.Models
{
    public class CollaborateurModel
    {

        [Required]
        [Display(Name = "Email : ")]
        [EmailAddress]
        public virtual string Email { get; set; }

         [Required]
        [Display(Name = "Mot de passe : ")]
        public virtual string Password { get; set; }

        [Required]
        [Display(Name = "Pseudo : ")]
        public virtual string Username { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int id { get; set; }

        [Display(Name = "Statut social : ")]
        public string marital_status { get; set; }

        [Required]
        [Display(Name = "Adresse : ")]
        public string address { get; set; }
        [Required]
        [Display(Name = "Nom : ")]
        public string Nom { get; set; }
        [Required]
        [Display(Name = "Prénom : ")]
        public string Prenom { get; set; }

        [HiddenInput(DisplayValue = false)]
        public Nullable<bool> is_deleted { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string id_user_fk { get; set; }

       
        [Display(Name = "Rôle: ")]
        public string Role { get; set; }

         
    }
}