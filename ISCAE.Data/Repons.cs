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
    
    public partial class Repons
    {
        public int ReponseId { get; set; }
        public string Contenu { get; set; }
        public System.DateTime DateReponse { get; set; }
        public int QuestionId { get; set; }
        public int EtudiantId { get; set; }
    
        public virtual Etudiant Etudiant { get; set; }
        public virtual Question Question { get; set; }
    }
}
