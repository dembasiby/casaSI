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
    
    public partial class EveUtilisationMatieresPremiere
    {
        public int CodeUtilisationRessource { get; set; }
        public int CodeMatierePremiere { get; set; }
        public float QuantiteMatierePremiere { get; set; }
    
        public virtual EveUtilisationRessource EveUtilisationRessource { get; set; }
        public virtual ResStockMatieresPremiere ResStockMatieresPremiere { get; set; }
    }
}
