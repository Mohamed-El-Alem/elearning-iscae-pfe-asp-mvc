//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISCAE.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Resultat
    {
        public int ResultatId { get; set; }
        public string Path { get; set; }
        public byte Semestre { get; set; }
        public string Annee { get; set; }
        public int AdministrateurId { get; set; }
        public int SpecialiteId { get; set; }
    
        public virtual Administrateur Administrateur { get; set; }
        public virtual Specialite Specialite { get; set; }
    }
}