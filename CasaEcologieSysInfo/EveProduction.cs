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
    
    public partial class EveProduction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EveProduction()
        {
            this.EveProductionProduitsSemiFinis = new HashSet<EveProductionProduitsSemiFini>();
            this.EveProductionStockProduitsFinis = new HashSet<EveProductionStockProduitsFini>();
        }
    
        public int CodeProduction { get; set; }
        public int CodeUtilisationRessources { get; set; }
        public Nullable<int> CodeEmploye_Resp_stock_produits_finis { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual AgeEmploye AgeEmploye { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveProductionProduitsSemiFini> EveProductionProduitsSemiFinis { get; set; }
        public virtual EveUtilisationRessource EveUtilisationRessource { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EveProductionStockProduitsFini> EveProductionStockProduitsFinis { get; set; }
    }
}
