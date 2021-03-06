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
    
    public partial class personne
    {
        public personne()
        {
            this.acomptefournisseurs = new HashSet<acomptefournisseur>();
            this.articles = new HashSet<article>();
            this.bonentrees = new HashSet<bonentree>();
            this.personne_modepayement = new HashSet<personne_modepayement>();
            this.personne_modepayement1 = new HashSet<personne_modepayement>();
            this.stockvariants = new HashSet<stockvariant>();
            this.bons = new HashSet<bon>();
            this.encaissementclients = new HashSet<encaissementclient>();
        }
    
        public int idPersonne { get; set; }
        public string DTYPE { get; set; }
        public string banque { get; set; }
        public string mail { get; set; }
        public string fax { get; set; }
        public string matriculeFiscal { get; set; }
        public string mobile1 { get; set; }
        public string mobile2 { get; set; }
        public string rib { get; set; }
        public string telephonefix { get; set; }
        public Nullable<int> ADRESSE_idAdresse { get; set; }
        public string aContacter { get; set; }
        public string assujettessiment { get; set; }
        public string cheminCIN { get; set; }
        public string cheminDossierJuridique { get; set; }
        public Nullable<float> maxRemise { get; set; }
        public string numRegistreCommerce { get; set; }
        public Nullable<float> plafondDebit { get; set; }
        public string raisonSociale { get; set; }
        public string fonction { get; set; }
        public string nomContact { get; set; }
        public string nomSociete { get; set; }
        public Nullable<float> plafondCredit { get; set; }
    
        public virtual ICollection<acomptefournisseur> acomptefournisseurs { get; set; }
        public virtual adresse adresse { get; set; }
        public virtual ICollection<article> articles { get; set; }
        public virtual ICollection<bonentree> bonentrees { get; set; }
        public virtual ICollection<personne_modepayement> personne_modepayement { get; set; }
        public virtual ICollection<personne_modepayement> personne_modepayement1 { get; set; }
        public virtual ICollection<stockvariant> stockvariants { get; set; }
        public virtual ICollection<bon> bons { get; set; }
        public virtual ICollection<encaissementclient> encaissementclients { get; set; }
    }
}
