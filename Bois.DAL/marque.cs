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
    
    public partial class marque
    {
        public marque()
        {
            this.articles = new HashSet<article>();
            this.articlesachetes = new HashSet<articlesachete>();
            this.stockvariants = new HashSet<stockvariant>();
        }
    
        public int ID { get; set; }
        public string CODEMARQUE { get; set; }
        public string LIBELLE { get; set; }
    
        public virtual ICollection<article> articles { get; set; }
        public virtual ICollection<articlesachete> articlesachetes { get; set; }
        public virtual ICollection<stockvariant> stockvariants { get; set; }
    }
}
