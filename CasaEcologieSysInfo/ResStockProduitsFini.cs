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
    
    public partial class ResStockProduitsFini
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ResStockProduitsFini()
        {
            this.EveProductionStockProduitsFinis = new HashSet<EveProductionStockProduitsFini>();
            this.EveVenteStockProduitsFinis = new HashSet<EveVenteStockProduitsFini>();
            this.EveTransvasements = new HashSet<EveTransvasement>();
            this.EveTransvasements1 = new HashSet<EveTransvasement>();
            this.EveSortieDonsOuDechetsProduitsFinis = new HashSet<EveSortieDonsOuDechetsProduitsFini>();
        }
    
        public int CodeProduit { get; set; }
        public string NomProduit { get; set; }
        public int StockProduit { get; set; }
        public int PrixDeVenteStandard { get; set; }
        public Nullable<int> CodeEmballage { get; set; }
        public int CoutUnitaire { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveProductionStockProduitsFini> EveProductionStockProduitsFinis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveVenteStockProduitsFini> EveVenteStockProduitsFinis { get; set; }
        public virtual ResStockMatieresPremiere ResStockMatieresPremiere { get; set; }
        public virtual ResStockProduitsFini ResStockProduitsFinis1 { get; set; }
        public virtual ResStockProduitsFini ResStockProduitsFini1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveTransvasement> EveTransvasements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveTransvasement> EveTransvasements1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveSortieDonsOuDechetsProduitsFini> EveSortieDonsOuDechetsProduitsFinis { get; set; }
    }
}
