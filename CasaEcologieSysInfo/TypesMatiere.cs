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
    
    public partial class TypesMatiere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypesMatiere()
        {
            this.ResStockMatieresPremieres = new HashSet<ResStockMatieresPremiere>();
        }
    
        public int CodeTypeMatiere { get; set; }
        public string NomType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResStockMatieresPremiere> ResStockMatieresPremieres { get; set; }
        public virtual TypesMatiere TypesMatieres1 { get; set; }
        public virtual TypesMatiere TypesMatiere1 { get; set; }
    }
}
