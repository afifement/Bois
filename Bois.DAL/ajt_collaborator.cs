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
    
    public partial class ajt_collaborator
    {
        public int id { get; set; }
        public string marital_status { get; set; }
        public string address { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string id_user_fk { get; set; }
        public Nullable<System.DateTime> deletion_date { get; set; }
    
        public virtual aspnetuser aspnetuser { get; set; }
    }
}
