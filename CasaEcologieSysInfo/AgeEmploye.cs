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
    
    public partial class AgeEmploye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgeEmploye()
        {
            this.EveAcquisitionServicesFournitures = new HashSet<EveAcquisitionServicesFourniture>();
            this.EveDecaissements = new HashSet<EveDecaissement>();
            this.EveEncaissements = new HashSet<EveEncaissement>();
            this.EvePresenceEmployes = new HashSet<EvePresenceEmploye>();
            this.EveProductions = new HashSet<EveProduction>();
            this.EveReceptionEquipementsInfrastructures = new HashSet<EveReceptionEquipementsInfrastructure>();
            this.EveReceptionMatieresPremieres = new HashSet<EveReceptionMatieresPremiere>();
            this.EveUtilisationRessources = new HashSet<EveUtilisationRessource>();
            this.EveUtilisationRessources1 = new HashSet<EveUtilisationRessource>();
            this.EveVentes = new HashSet<EveVente>();
            this.EvePaiementEmployes = new HashSet<EvePaiementEmploye>();
        }
    
        public int CodeEmploye { get; set; }
        public string PrenomNom { get; set; }
        public string Poste { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveAcquisitionServicesFourniture> EveAcquisitionServicesFournitures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveDecaissement> EveDecaissements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveEncaissement> EveEncaissements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvePresenceEmploye> EvePresenceEmployes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveProduction> EveProductions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveReceptionEquipementsInfrastructure> EveReceptionEquipementsInfrastructures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveReceptionMatieresPremiere> EveReceptionMatieresPremieres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveUtilisationRessource> EveUtilisationRessources { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveUtilisationRessource> EveUtilisationRessources1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveVente> EveVentes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvePaiementEmploye> EvePaiementEmployes { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
