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
    
    public partial class referencearticle
    {
        public referencearticle()
        {
            this.articles = new HashSet<article>();
            this.articlesachetes = new HashSet<articlesachete>();
            this.stockvariants = new HashSet<stockvariant>();
            this.souscategories = new HashSet<souscategorie>();
        }
    
        public string refArticle { get; set; }
        public Nullable<float> epaisseur { get; set; }
        public Nullable<float> largeur { get; set; }
    
        public virtual ICollection<article> articles { get; set; }
        public virtual ICollection<articlesachete> articlesachetes { get; set; }
        public virtual ICollection<stockvariant> stockvariants { get; set; }
        public virtual ICollection<souscategorie> souscategories { get; set; }
    }
}
