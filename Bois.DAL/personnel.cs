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
    
    public partial class personnel
    {
        public personnel()
        {
            this.acomptepersonnels = new HashSet<acomptepersonnel>();
        }
    
        public int IDPERSONNEL { get; set; }
        public string CHEMINCIN { get; set; }
        public string CHEMINCOPIECONTRAT { get; set; }
        public string CIN { get; set; }
        public string DATEARRETCONTRAT { get; set; }
        public string DATEEMBAUCHE { get; set; }
        public string FONCTION { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public Nullable<float> SALAIREDEBASE { get; set; }
    
        public virtual ICollection<acomptepersonnel> acomptepersonnels { get; set; }
    }
}