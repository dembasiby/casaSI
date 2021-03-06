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
    
    public partial class EveDecaissement
    {
        public int CodeDecaissement { get; set; }
        public Nullable<int> CodeFournisseurMatierePremiere { get; set; }
        public Nullable<int> CodeFournisseurService { get; set; }
        public Nullable<int> CodeAutreFournisseur { get; set; }
        public int CodeEmploye { get; set; }
        public Nullable<int> CodeAcquisitionServiceFourniture { get; set; }
        public Nullable<int> CodeReceptionEquipementInfrastructure { get; set; }
        public Nullable<int> CodeReceptionMatierePremiere { get; set; }
        public int CodeCompte { get; set; }
        public string Description { get; set; }
        public System.DateTime DateDecaissement { get; set; }
        public decimal Montant { get; set; }
        public Nullable<int> CodePaiementEmploye { get; set; }
        public Nullable<int> CodeReceptionDonMatierePremiere { get; set; }
        public bool DecaissementInterne { get; set; }
    
        public virtual AgeAutreFournisseur AgeAutreFournisseur { get; set; }
        public virtual AgeEmploye AgeEmploye { get; set; }
        public virtual AgeFournisseursMatieresPremiere AgeFournisseursMatieresPremiere { get; set; }
        public virtual AgeFournisseursServicesFourniture AgeFournisseursServicesFourniture { get; set; }
        public virtual EveAcquisitionServicesFourniture EveAcquisitionServicesFourniture { get; set; }
        public virtual EveReceptionEquipementsInfrastructure EveReceptionEquipementsInfrastructure { get; set; }
        public virtual EveReceptionMatieresPremiere EveReceptionMatieresPremiere { get; set; }
        public virtual ResComptesTresorerie ResComptesTresorerie { get; set; }
        public virtual EvePaiementEmploye EvePaiementEmploye { get; set; }
        public virtual EveReceptionDonsMatieresPremiere EveReceptionDonsMatieresPremiere { get; set; }
    }
}
