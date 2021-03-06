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
    
    public partial class AgeFournisseursMatieresPremiere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgeFournisseursMatieresPremiere()
        {
            this.EveDecaissements = new HashSet<EveDecaissement>();
            this.EveReceptionMatieresPremieres = new HashSet<EveReceptionMatieresPremiere>();
            this.EveReceptionDonsMatieresPremieres = new HashSet<EveReceptionDonsMatieresPremiere>();
        }
    
        public int CodeFournisseurMatierePremiere { get; set; }
        public string Nom { get; set; }
        public string Localite { get; set; }
        public decimal SoldeDette { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveDecaissement> EveDecaissements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveReceptionMatieresPremiere> EveReceptionMatieresPremieres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveReceptionDonsMatieresPremiere> EveReceptionDonsMatieresPremieres { get; set; }
    }
}
