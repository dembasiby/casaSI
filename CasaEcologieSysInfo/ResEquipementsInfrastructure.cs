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
    
    public partial class ResEquipementsInfrastructure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ResEquipementsInfrastructure()
        {
            this.EveReceptionEquipementsInfrastructures = new HashSet<EveReceptionEquipementsInfrastructure>();
            this.EveUtilisationRessources = new HashSet<EveUtilisationRessource>();
        }
    
        public int CodeEquipementInfrastructure { get; set; }
        public string Nom { get; set; }
        public System.DateTime DateAcquisition { get; set; }
        public int DureeDeVie { get; set; }
        public int Quantite { get; set; }
        public bool MaterielDeProduction { get; set; }
        public decimal Montant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveReceptionEquipementsInfrastructure> EveReceptionEquipementsInfrastructures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveUtilisationRessource> EveUtilisationRessources { get; set; }
    }
}
