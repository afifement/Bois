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
    
    public partial class bon
    {
        public bon()
        {
            this.encaissementclients = new HashSet<encaissementclient>();
            this.articlesachetes = new HashSet<articlesachete>();
            this.personnes = new HashSet<personne>();
        }
    
        public int ID { get; set; }
        public string DTYPE { get; set; }
        public string DATEBON { get; set; }
        public Nullable<bool> ESTPAYE { get; set; }
        public string MODEPAYEMENT { get; set; }
        public Nullable<float> TOTTTC { get; set; }
        public Nullable<float> TOTTVA { get; set; }
        public Nullable<float> TOTALBRUT { get; set; }
        public Nullable<float> TOTALHT { get; set; }
        public Nullable<float> TOTALREMISE { get; set; }
        public Nullable<bool> ESTFACTURE { get; set; }
        public string NUMBL { get; set; }
        public Nullable<bool> ESTLIVREE { get; set; }
        public string NUMBC { get; set; }
        public Nullable<int> NBREDUPLICATA { get; set; }
        public string NUMFACT { get; set; }
    
        public virtual ICollection<encaissementclient> encaissementclients { get; set; }
        public virtual ICollection<articlesachete> articlesachetes { get; set; }
        public virtual ICollection<personne> personnes { get; set; }
    }
}
