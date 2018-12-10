﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CasaDBEntities2 : DbContext
    {
        public CasaDBEntities2()
            : base("name=CasaDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AgeAutreFournisseur> AgeAutreFournisseurs { get; set; }
        public virtual DbSet<AgeClient> AgeClients { get; set; }
        public virtual DbSet<AgeEmploye> AgeEmployes { get; set; }
        public virtual DbSet<AgeFournisseursMatieresPremiere> AgeFournisseursMatieresPremieres { get; set; }
        public virtual DbSet<AgeFournisseursServicesFourniture> AgeFournisseursServicesFournitures { get; set; }
        public virtual DbSet<EveAcquisitionServicesFourniture> EveAcquisitionServicesFournitures { get; set; }
        public virtual DbSet<EveDecaissement> EveDecaissements { get; set; }
        public virtual DbSet<EveEncaissement> EveEncaissements { get; set; }
        public virtual DbSet<EveEncaissementsVente> EveEncaissementsVentes { get; set; }
        public virtual DbSet<EvePresenceEmploye> EvePresenceEmployes { get; set; }
        public virtual DbSet<EveProductionProduitsSemiFini> EveProductionProduitsSemiFinis { get; set; }
        public virtual DbSet<EveProduction> EveProductions { get; set; }
        public virtual DbSet<EveProductionStockProduitsFini> EveProductionStockProduitsFinis { get; set; }
        public virtual DbSet<EveReceptionEquipementsInfrastructure> EveReceptionEquipementsInfrastructures { get; set; }
        public virtual DbSet<EveReceptionMatieresPremiere> EveReceptionMatieresPremieres { get; set; }
        public virtual DbSet<EveUtilisationMatieresPremiere> EveUtilisationMatieresPremieres { get; set; }
        public virtual DbSet<EveUtilisationProduitsSemiFini> EveUtilisationProduitsSemiFinis { get; set; }
        public virtual DbSet<EveUtilisationRessource> EveUtilisationRessources { get; set; }
        public virtual DbSet<EveVente> EveVentes { get; set; }
        public virtual DbSet<EveVenteStockProduitsFini> EveVenteStockProduitsFinis { get; set; }
        public virtual DbSet<ResComptesTresorerie> ResComptesTresoreries { get; set; }
        public virtual DbSet<ResEquipementsInfrastructure> ResEquipementsInfrastructures { get; set; }
        public virtual DbSet<ResServicesFourniture> ResServicesFournitures { get; set; }
        public virtual DbSet<ResStockMatieresPremiere> ResStockMatieresPremieres { get; set; }
        public virtual DbSet<ResStockProduitsFini> ResStockProduitsFinis { get; set; }
        public virtual DbSet<ResStockProduitsSemiFini> ResStockProduitsSemiFinis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
