//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bois.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class modepayement
    {
        public modepayement()
        {
            this.personne_modepayement = new HashSet<personne_modepayement>();
        }
    
        public int IDMODEPAYEMENT { get; set; }
        public string libelleMode { get; set; }
    
        public virtual ICollection<personne_modepayement> personne_modepayement { get; set; }
    }
}
