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
    
    public partial class EveEncaissementsCreance
    {
        public int CodeEncaissementCreance { get; set; }
        public int CodeClient { get; set; }
        public decimal MontantEncaisse { get; set; }
        public System.DateTime DateEncaissement { get; set; }
        public int CodeEncaissement { get; set; }
    
        public virtual AgeClient AgeClient { get; set; }
        public virtual EveEncaissement EveEncaissement { get; set; }
    }
}
