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
    
    public partial class EveSortieDonsOuDechetsProduitsFini
    {
        public int CodeSortieDonsDechetsPrdtFini { get; set; }
        public System.DateTime DateSortie { get; set; }
        public string Description { get; set; }
        public int CodeProduitFini { get; set; }
        public int QuantiteProduitFini { get; set; }
        public int CodeResponsableSortie { get; set; }
    
        public virtual AgeEmploye AgeEmploye { get; set; }
        public virtual ResStockProduitsFini ResStockProduitsFini { get; set; }
    }
}
