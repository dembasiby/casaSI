//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CasaEcologieSysInfo
{
    using System;
    using System.Collections.Generic;
    
    public partial class EveReceptionMatieresPremiere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EveReceptionMatieresPremiere()
        {
            this.EveDecaissements = new HashSet<EveDecaissement>();
        }
    
        public int CodeReceptionMatierePremiere { get; set; }
        public int CodeMatierePremiere { get; set; }
        public System.DateTime DateReception { get; set; }
        public float Quantite { get; set; }
        public decimal Montant { get; set; }
        public int CodeFournisseurMatierePremiere { get; set; }
        public int CodeEmploye { get; set; }
    
        public virtual AgeEmploye AgeEmploye { get; set; }
        public virtual AgeFournisseursMatieresPremiere AgeFournisseursMatieresPremiere { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveDecaissement> EveDecaissements { get; set; }
        public virtual ResStockMatieresPremiere ResStockMatieresPremiere { get; set; }
    }
}
