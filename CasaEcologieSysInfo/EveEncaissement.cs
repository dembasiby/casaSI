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
    
    public partial class EveEncaissement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EveEncaissement()
        {
            this.EveEncaissementsVentes = new HashSet<EveEncaissementsVente>();
            this.EveEncaissementsAutres = new HashSet<EveEncaissementsAutre>();
        }
    
        public int CodeEncaissement { get; set; }
        public int CodeEmploye { get; set; }
        public int CodeCompte { get; set; }
    
        public virtual AgeEmploye AgeEmploye { get; set; }
        public virtual ResComptesTresorerie ResComptesTresorerie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveEncaissementsVente> EveEncaissementsVentes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveEncaissementsAutre> EveEncaissementsAutres { get; set; }
    }
}
