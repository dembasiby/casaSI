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
    
    public partial class EveTransvasement
    {
        public int CodeTransvasage { get; set; }
        public System.DateTime DateOperation { get; set; }
        public int CodeEmballageInitial { get; set; }
        public double QuantiteATransvaser { get; set; }
        public int CodeEmballageFinal { get; set; }
        public int CodeProduitInitial { get; set; }
        public int CodeProduitFinal { get; set; }
    
        public virtual ResStockMatieresPremiere ResStockMatieresPremiere { get; set; }
        public virtual ResStockMatieresPremiere ResStockMatieresPremiere1 { get; set; }
        public virtual ResStockProduitsFini ResStockProduitsFini { get; set; }
        public virtual ResStockProduitsFini ResStockProduitsFini1 { get; set; }
    }
}
