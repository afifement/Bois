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
    
    public partial class bonentree
    {
        public bonentree()
        {
            this.articles = new HashSet<article>();
        }
    
        public int idBonEntree { get; set; }
        public string dateBonEntree { get; set; }
        public Nullable<bool> estFacture { get; set; }
        public Nullable<float> netAPayer { get; set; }
        public string numBonEntree { get; set; }
        public Nullable<float> totalBrut { get; set; }
        public Nullable<float> totalHT { get; set; }
        public Nullable<float> totalRemise { get; set; }
        public Nullable<float> totalTTC { get; set; }
        public Nullable<float> totalTVA { get; set; }
        public Nullable<int> FOURNISSER_idPersonne { get; set; }
    
        public virtual personne personne { get; set; }
        public virtual ICollection<article> articles { get; set; }
    }
}