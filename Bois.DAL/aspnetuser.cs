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
    
    public partial class aspnetuser
    {
        public aspnetuser()
        {
            this.ajt_collaborator = new HashSet<ajt_collaborator>();
            this.ajt_photo = new HashSet<ajt_photo>();
            this.aspnetuserclaims = new HashSet<aspnetuserclaim>();
            this.aspnetuserlogins = new HashSet<aspnetuserlogin>();
            this.aspnetroles = new HashSet<aspnetrole>();
        }
    
        public string Id { get; set; }
        public string Hometown { get; set; }
        public string Email { get; set; }
        public sbyte EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public sbyte PhoneNumberConfirmed { get; set; }
        public sbyte TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public sbyte LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
    
        public virtual ICollection<ajt_collaborator> ajt_collaborator { get; set; }
        public virtual ICollection<ajt_photo> ajt_photo { get; set; }
        public virtual ICollection<aspnetuserclaim> aspnetuserclaims { get; set; }
        public virtual ICollection<aspnetuserlogin> aspnetuserlogins { get; set; }
        public virtual aspnetusersext aspnetusersext { get; set; }
        public virtual ICollection<aspnetrole> aspnetroles { get; set; }
    }
}
