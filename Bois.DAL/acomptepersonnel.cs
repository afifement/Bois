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
    
    public partial class acomptepersonnel
    {
        public acomptepersonnel()
        {
            this.personnels = new HashSet<personnel>();
        }
    
        public int IDACOMPTEPERSONNEL { get; set; }
        public Nullable<bool> ARCHIVE { get; set; }
        public string DATEACOMPTE { get; set; }
        public Nullable<float> MONTANTACOMPTE { get; set; }
        public Nullable<float> SOLDERESTANT { get; set; }
    
        public virtual ICollection<personnel> personnels { get; set; }
    }
}
