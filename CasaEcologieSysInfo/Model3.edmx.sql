
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/02/2020 09:19:20
-- Generated from EDMX file: C:\Users\HP\source\repos\casaSI\CasaEcologieSysInfo\Model3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CasaDB2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EveAcquisitionServicesFournitures_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveAcquisitionServicesFournitures] DROP CONSTRAINT [FK_EveAcquisitionServicesFournitures_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveAcquisitionServicesFournitures_AgeFournisseursServicesFournitures]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveAcquisitionServicesFournitures] DROP CONSTRAINT [FK_EveAcquisitionServicesFournitures_AgeFournisseursServicesFournitures];
GO
IF OBJECT_ID(N'[dbo].[FK_EveAcquisitionServicesFournitures_ResServicesFournitures]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveAcquisitionServicesFournitures] DROP CONSTRAINT [FK_EveAcquisitionServicesFournitures_ResServicesFournitures];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_AgeAutreFournisseurs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_AgeAutreFournisseurs];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_AgeFournisseursMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_AgeFournisseursMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_AgeFournisseursServicesFournitures]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_AgeFournisseursServicesFournitures];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_EveAcquisitionServicesFournitures]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_EveAcquisitionServicesFournitures];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_EvePaiementEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_EvePaiementEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_EveReceptionDonsMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_EveReceptionDonsMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_EveReceptionEquipementsInfrastructures]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_EveReceptionEquipementsInfrastructures];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_EveReceptionMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_EveReceptionMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveDecaissements_ResComptesTresorerie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveDecaissements] DROP CONSTRAINT [FK_EveDecaissements_ResComptesTresorerie];
GO
IF OBJECT_ID(N'[dbo].[FK_EveEncaissements_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveEncaissements] DROP CONSTRAINT [FK_EveEncaissements_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveEncaissements_ResComptesTresorerie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveEncaissements] DROP CONSTRAINT [FK_EveEncaissements_ResComptesTresorerie];
GO
IF OBJECT_ID(N'[dbo].[FK_EveEncaissementsAutres_EveEncaissements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveEncaissementsAutres] DROP CONSTRAINT [FK_EveEncaissementsAutres_EveEncaissements];
GO
IF OBJECT_ID(N'[dbo].[FK_EveEncaissementsCreances_AgeClients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveEncaissementsCreances] DROP CONSTRAINT [FK_EveEncaissementsCreances_AgeClients];
GO
IF OBJECT_ID(N'[dbo].[FK_EveEncaissementsCreances_EveEncaissements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveEncaissementsCreances] DROP CONSTRAINT [FK_EveEncaissementsCreances_EveEncaissements];
GO
IF OBJECT_ID(N'[dbo].[FK_EveEncaissementsVentes_AgeClients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveEncaissementsVentes] DROP CONSTRAINT [FK_EveEncaissementsVentes_AgeClients];
GO
IF OBJECT_ID(N'[dbo].[FK_EveEncaissementsVentes_EveEncaissements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveEncaissementsVentes] DROP CONSTRAINT [FK_EveEncaissementsVentes_EveEncaissements];
GO
IF OBJECT_ID(N'[dbo].[FK_EveEncaissementsVentes_EveVentes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveEncaissementsVentes] DROP CONSTRAINT [FK_EveEncaissementsVentes_EveVentes];
GO
IF OBJECT_ID(N'[dbo].[FK_EvePaiementEmployes_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvePaiementEmployes] DROP CONSTRAINT [FK_EvePaiementEmployes_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EvePresenceEmployes_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvePresenceEmployes] DROP CONSTRAINT [FK_EvePresenceEmployes_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveProductionProduitsSemiFinis_EveProductions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveProductionProduitsSemiFinis] DROP CONSTRAINT [FK_EveProductionProduitsSemiFinis_EveProductions];
GO
IF OBJECT_ID(N'[dbo].[FK_EveProductionProduitsSemiFinis_ResStockProduitsSemiFinis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveProductionProduitsSemiFinis] DROP CONSTRAINT [FK_EveProductionProduitsSemiFinis_ResStockProduitsSemiFinis];
GO
IF OBJECT_ID(N'[dbo].[FK_EveProductions_AgeEmployes1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveProductions] DROP CONSTRAINT [FK_EveProductions_AgeEmployes1];
GO
IF OBJECT_ID(N'[dbo].[FK_EveProductions_EveUtilisationRessources]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveProductions] DROP CONSTRAINT [FK_EveProductions_EveUtilisationRessources];
GO
IF OBJECT_ID(N'[dbo].[FK_EveProductionStockProduitsFinis_EveProductions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveProductionStockProduitsFinis] DROP CONSTRAINT [FK_EveProductionStockProduitsFinis_EveProductions];
GO
IF OBJECT_ID(N'[dbo].[FK_EveProductionStockProduitsFinis_ResStockProduitsFinis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveProductionStockProduitsFinis] DROP CONSTRAINT [FK_EveProductionStockProduitsFinis_ResStockProduitsFinis];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionDonsMatieresPremieres_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionDonsMatieresPremieres] DROP CONSTRAINT [FK_EveReceptionDonsMatieresPremieres_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionDonsMatieresPremieres_AgeFournisseursMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionDonsMatieresPremieres] DROP CONSTRAINT [FK_EveReceptionDonsMatieresPremieres_AgeFournisseursMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionDonsMatieresPremieres_ResStockMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionDonsMatieresPremieres] DROP CONSTRAINT [FK_EveReceptionDonsMatieresPremieres_ResStockMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionEquipementsInfrastructures_AgeAutreFournisseurs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionEquipementsInfrastructures] DROP CONSTRAINT [FK_EveReceptionEquipementsInfrastructures_AgeAutreFournisseurs];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionEquipementsInfrastructures_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionEquipementsInfrastructures] DROP CONSTRAINT [FK_EveReceptionEquipementsInfrastructures_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionEquipementsInfrastructures_ResEquipementsInfrastructures]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionEquipementsInfrastructures] DROP CONSTRAINT [FK_EveReceptionEquipementsInfrastructures_ResEquipementsInfrastructures];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionMatieresPremieres_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionMatieresPremieres] DROP CONSTRAINT [FK_EveReceptionMatieresPremieres_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionMatieresPremieres_AgeFournisseursMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionMatieresPremieres] DROP CONSTRAINT [FK_EveReceptionMatieresPremieres_AgeFournisseursMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveReceptionMatieresPremieres_ResStockMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveReceptionMatieresPremieres] DROP CONSTRAINT [FK_EveReceptionMatieresPremieres_ResStockMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveSortieDechetsMatieresPremieres_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveSortieDechetsMatieresPremieres] DROP CONSTRAINT [FK_EveSortieDechetsMatieresPremieres_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveSortieDechetsMatieresPremieres_AgeEmployes1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveSortieDechetsMatieresPremieres] DROP CONSTRAINT [FK_EveSortieDechetsMatieresPremieres_AgeEmployes1];
GO
IF OBJECT_ID(N'[dbo].[FK_EveSortieDechetsMatieresPremieres_ResStockMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveSortieDechetsMatieresPremieres] DROP CONSTRAINT [FK_EveSortieDechetsMatieresPremieres_ResStockMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveTransvasements_ResStockMatieresPremieres_Final]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveTransvasements] DROP CONSTRAINT [FK_EveTransvasements_ResStockMatieresPremieres_Final];
GO
IF OBJECT_ID(N'[dbo].[FK_EveTransvasements_ResStockMatieresPremieres_Initial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveTransvasements] DROP CONSTRAINT [FK_EveTransvasements_ResStockMatieresPremieres_Initial];
GO
IF OBJECT_ID(N'[dbo].[FK_EveTransvasements_ResStockProduitsFinis_Final]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveTransvasements] DROP CONSTRAINT [FK_EveTransvasements_ResStockProduitsFinis_Final];
GO
IF OBJECT_ID(N'[dbo].[FK_EveTransvasements_ResStockProduitsFinis_Initial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveTransvasements] DROP CONSTRAINT [FK_EveTransvasements_ResStockProduitsFinis_Initial];
GO
IF OBJECT_ID(N'[dbo].[FK_EveUtilisationEquipementInfrastructures_EveUtilisationRessources]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveUtilisationEquipementInfrastructures] DROP CONSTRAINT [FK_EveUtilisationEquipementInfrastructures_EveUtilisationRessources];
GO
IF OBJECT_ID(N'[dbo].[FK_EveUtilisationEquipementInfrastructures_ResEquipementsInfrastructures]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveUtilisationEquipementInfrastructures] DROP CONSTRAINT [FK_EveUtilisationEquipementInfrastructures_ResEquipementsInfrastructures];
GO
IF OBJECT_ID(N'[dbo].[FK_EveUtilisationMatieresPremieres_EveUtilisationRessources]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveUtilisationMatieresPremieres] DROP CONSTRAINT [FK_EveUtilisationMatieresPremieres_EveUtilisationRessources];
GO
IF OBJECT_ID(N'[dbo].[FK_EveUtilisationMatieresPremieres_ResStockMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveUtilisationMatieresPremieres] DROP CONSTRAINT [FK_EveUtilisationMatieresPremieres_ResStockMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_EveUtilisationProduitsSemiFinis_EveUtilisationRessources]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveUtilisationProduitsSemiFinis] DROP CONSTRAINT [FK_EveUtilisationProduitsSemiFinis_EveUtilisationRessources];
GO
IF OBJECT_ID(N'[dbo].[FK_EveUtilisationProduitsSemiFinis_ResStockProduitsSemiFinis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveUtilisationProduitsSemiFinis] DROP CONSTRAINT [FK_EveUtilisationProduitsSemiFinis_ResStockProduitsSemiFinis];
GO
IF OBJECT_ID(N'[dbo].[FK_EveUtilisationRessources_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveUtilisationRessources] DROP CONSTRAINT [FK_EveUtilisationRessources_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveUtilisationRessources_AgeEmployes1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveUtilisationRessources] DROP CONSTRAINT [FK_EveUtilisationRessources_AgeEmployes1];
GO
IF OBJECT_ID(N'[dbo].[FK_EveVentes_AgeClients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveVentes] DROP CONSTRAINT [FK_EveVentes_AgeClients];
GO
IF OBJECT_ID(N'[dbo].[FK_EveVentes_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveVentes] DROP CONSTRAINT [FK_EveVentes_AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveVenteStockProduitsFinis_EveVentes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveVenteStockProduitsFinis] DROP CONSTRAINT [FK_EveVenteStockProduitsFinis_EveVentes];
GO
IF OBJECT_ID(N'[dbo].[FK_EveVenteStockProduitsFinis_ResStockProduitsFinis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EveVenteStockProduitsFinis] DROP CONSTRAINT [FK_EveVenteStockProduitsFinis_ResStockProduitsFinis];
GO
IF OBJECT_ID(N'[dbo].[FK_ResStockProduitsFinis_ResStockMatieresPremieresEmballages]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResStockProduitsFinis] DROP CONSTRAINT [FK_ResStockProduitsFinis_ResStockMatieresPremieresEmballages];
GO
IF OBJECT_ID(N'[dbo].[FK_ResStockProduitsFinis_ResStockProduitsFinis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResStockProduitsFinis] DROP CONSTRAINT [FK_ResStockProduitsFinis_ResStockProduitsFinis];
GO
IF OBJECT_ID(N'[dbo].[FK_ResStockProduitsSemiFinis_ResStockMatieresPremieres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResStockProduitsSemiFinis] DROP CONSTRAINT [FK_ResStockProduitsSemiFinis_ResStockMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[FK_ResStockProduitsSemiFinis_ResStockProduitsSemiFinis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResStockProduitsSemiFinis] DROP CONSTRAINT [FK_ResStockProduitsSemiFinis_ResStockProduitsSemiFinis];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilisateurs_AgeEmployes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Utilisateurs] DROP CONSTRAINT [FK_Utilisateurs_AgeEmployes];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AgeAutreFournisseurs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AgeAutreFournisseurs];
GO
IF OBJECT_ID(N'[dbo].[AgeClients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AgeClients];
GO
IF OBJECT_ID(N'[dbo].[AgeEmployes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AgeEmployes];
GO
IF OBJECT_ID(N'[dbo].[AgeFournisseursMatieresPremieres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AgeFournisseursMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[AgeFournisseursServicesFournitures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AgeFournisseursServicesFournitures];
GO
IF OBJECT_ID(N'[dbo].[EveAcquisitionServicesFournitures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveAcquisitionServicesFournitures];
GO
IF OBJECT_ID(N'[dbo].[EveDecaissements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveDecaissements];
GO
IF OBJECT_ID(N'[dbo].[EveEncaissements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveEncaissements];
GO
IF OBJECT_ID(N'[dbo].[EveEncaissementsAutres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveEncaissementsAutres];
GO
IF OBJECT_ID(N'[dbo].[EveEncaissementsCreances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveEncaissementsCreances];
GO
IF OBJECT_ID(N'[dbo].[EveEncaissementsVentes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveEncaissementsVentes];
GO
IF OBJECT_ID(N'[dbo].[EvePaiementEmployes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvePaiementEmployes];
GO
IF OBJECT_ID(N'[dbo].[EvePresenceEmployes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvePresenceEmployes];
GO
IF OBJECT_ID(N'[dbo].[EveProductionProduitsSemiFinis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveProductionProduitsSemiFinis];
GO
IF OBJECT_ID(N'[dbo].[EveProductions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveProductions];
GO
IF OBJECT_ID(N'[dbo].[EveProductionStockProduitsFinis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveProductionStockProduitsFinis];
GO
IF OBJECT_ID(N'[dbo].[EveReceptionDonsMatieresPremieres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveReceptionDonsMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[EveReceptionEquipementsInfrastructures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveReceptionEquipementsInfrastructures];
GO
IF OBJECT_ID(N'[dbo].[EveReceptionMatieresPremieres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveReceptionMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[EveSortieDechetsMatieresPremieres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveSortieDechetsMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[EveTransvasements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveTransvasements];
GO
IF OBJECT_ID(N'[dbo].[EveUtilisationEquipementInfrastructures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveUtilisationEquipementInfrastructures];
GO
IF OBJECT_ID(N'[dbo].[EveUtilisationMatieresPremieres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveUtilisationMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[EveUtilisationProduitsSemiFinis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveUtilisationProduitsSemiFinis];
GO
IF OBJECT_ID(N'[dbo].[EveUtilisationRessources]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveUtilisationRessources];
GO
IF OBJECT_ID(N'[dbo].[EveVentes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveVentes];
GO
IF OBJECT_ID(N'[dbo].[EveVenteStockProduitsFinis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EveVenteStockProduitsFinis];
GO
IF OBJECT_ID(N'[dbo].[ResComptesTresorerie]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResComptesTresorerie];
GO
IF OBJECT_ID(N'[dbo].[ResEquipementsInfrastructures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResEquipementsInfrastructures];
GO
IF OBJECT_ID(N'[dbo].[ResServicesFournitures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResServicesFournitures];
GO
IF OBJECT_ID(N'[dbo].[ResStockMatieresPremieres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResStockMatieresPremieres];
GO
IF OBJECT_ID(N'[dbo].[ResStockProduitsFinis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResStockProduitsFinis];
GO
IF OBJECT_ID(N'[dbo].[ResStockProduitsSemiFinis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResStockProduitsSemiFinis];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Utilisateurs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Utilisateurs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AgeAutreFournisseurs'
CREATE TABLE [dbo].[AgeAutreFournisseurs] (
    [CodeAutreFournisseur] int IDENTITY(1,1) NOT NULL,
    [NomAutreFournisseur] nvarchar(50)  NOT NULL,
    [Localite] nvarchar(50)  NULL,
    [SoldeInitialDetteFournisseur] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'AgeClients'
CREATE TABLE [dbo].[AgeClients] (
    [CodeClient] int IDENTITY(1,1) NOT NULL,
    [NomClient] nvarchar(50)  NOT NULL,
    [Localite] nvarchar(50)  NOT NULL,
    [SoldeInitialeCreance] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'AgeEmployes'
CREATE TABLE [dbo].[AgeEmployes] (
    [CodeEmploye] int IDENTITY(1,1) NOT NULL,
    [PrenomNom] nvarchar(50)  NOT NULL,
    [Poste] nvarchar(50)  NOT NULL,
    [Actif] bit  NOT NULL
);
GO

-- Creating table 'AgeFournisseursMatieresPremieres'
CREATE TABLE [dbo].[AgeFournisseursMatieresPremieres] (
    [CodeFournisseurMatierePremiere] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(50)  NOT NULL,
    [Localite] nvarchar(50)  NOT NULL,
    [SoldeDette] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'AgeFournisseursServicesFournitures'
CREATE TABLE [dbo].[AgeFournisseursServicesFournitures] (
    [CodeFournisseurServiceFourniture] int IDENTITY(1,1) NOT NULL,
    [NomFournisseurServiceFourniture] nvarchar(50)  NOT NULL,
    [Localite] nvarchar(50)  NOT NULL,
    [SoldeDette] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'EveAcquisitionServicesFournitures'
CREATE TABLE [dbo].[EveAcquisitionServicesFournitures] (
    [CodeAcquisitionServiceFourniture] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Montant] decimal(19,4)  NOT NULL,
    [CodeServiceFourniture] int  NOT NULL,
    [CodeFournisseurServiceFourniture] int  NOT NULL,
    [CodeEmploye] int  NULL,
    [TransportServiceFourniture] decimal(19,4)  NULL
);
GO

-- Creating table 'EveDecaissements'
CREATE TABLE [dbo].[EveDecaissements] (
    [CodeDecaissement] int IDENTITY(1,1) NOT NULL,
    [CodeFournisseurMatierePremiere] int  NULL,
    [CodeFournisseurService] int  NULL,
    [CodeAutreFournisseur] int  NULL,
    [CodeEmploye] int  NOT NULL,
    [CodeAcquisitionServiceFourniture] int  NULL,
    [CodeReceptionEquipementInfrastructure] int  NULL,
    [CodeReceptionMatierePremiere] int  NULL,
    [CodeCompte] int  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DateDecaissement] datetime  NOT NULL,
    [Montant] decimal(19,4)  NOT NULL,
    [CodePaiementEmploye] int  NULL,
    [CodeReceptionDonMatierePremiere] int  NULL
);
GO

-- Creating table 'EveEncaissements'
CREATE TABLE [dbo].[EveEncaissements] (
    [CodeEncaissement] int IDENTITY(1,1) NOT NULL,
    [CodeEmploye] int  NOT NULL,
    [CodeCompte] int  NOT NULL
);
GO

-- Creating table 'EveEncaissementsVentes'
CREATE TABLE [dbo].[EveEncaissementsVentes] (
    [CodeEncaissement] int  NOT NULL,
    [CodeVente] int  NOT NULL,
    [MontantEncaisse] decimal(19,4)  NOT NULL,
    [DateEncaissement] datetime  NOT NULL,
    [CodeClient] int  NOT NULL
);
GO

-- Creating table 'EvePresenceEmployes'
CREATE TABLE [dbo].[EvePresenceEmployes] (
    [CodePresence] int IDENTITY(1,1) NOT NULL,
    [CodeEmploye] int  NOT NULL,
    [CodeUtilisationDesRessources] int  NULL,
    [Date] datetime  NOT NULL,
    [RemunerationJournaliere] int  NULL
);
GO

-- Creating table 'EveProductionProduitsSemiFinis'
CREATE TABLE [dbo].[EveProductionProduitsSemiFinis] (
    [CodeProduction] int  NOT NULL,
    [CodeProduitSemiFini] int  NOT NULL,
    [QuantiteProduitSemiFini] real  NOT NULL
);
GO

-- Creating table 'EveProductions'
CREATE TABLE [dbo].[EveProductions] (
    [CodeProduction] int IDENTITY(1,1) NOT NULL,
    [CodeUtilisationRessources] int  NOT NULL,
    [CodeEmploye_Resp_stock_produits_finis] int  NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'EveProductionStockProduitsFinis'
CREATE TABLE [dbo].[EveProductionStockProduitsFinis] (
    [CodeProduction] int  NOT NULL,
    [CodeProduitFini] int  NOT NULL,
    [QuantiteProduitFini] int  NOT NULL
);
GO

-- Creating table 'EveReceptionEquipementsInfrastructures'
CREATE TABLE [dbo].[EveReceptionEquipementsInfrastructures] (
    [CodeReceptionEquipementInfrastructure] int IDENTITY(1,1) NOT NULL,
    [CodeEquipementInfrastructure] int  NOT NULL,
    [CodeEmploye] int  NOT NULL,
    [CodeAutreFournisseur] int  NOT NULL
);
GO

-- Creating table 'EveReceptionMatieresPremieres'
CREATE TABLE [dbo].[EveReceptionMatieresPremieres] (
    [CodeReceptionMatierePremiere] int IDENTITY(1,1) NOT NULL,
    [CodeMatierePremiere] int  NOT NULL,
    [DateReception] datetime  NOT NULL,
    [Quantite] real  NOT NULL,
    [Montant] decimal(19,4)  NOT NULL,
    [CodeFournisseurMatierePremiere] int  NOT NULL,
    [CodeEmploye] int  NOT NULL,
    [TransportMatierePremiere] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'EveUtilisationMatieresPremieres'
CREATE TABLE [dbo].[EveUtilisationMatieresPremieres] (
    [CodeUtilisationRessource] int  NOT NULL,
    [CodeMatierePremiere] int  NOT NULL,
    [QuantiteMatierePremiere] real  NOT NULL
);
GO

-- Creating table 'EveUtilisationProduitsSemiFinis'
CREATE TABLE [dbo].[EveUtilisationProduitsSemiFinis] (
    [CodeUtilisationRessource] int  NOT NULL,
    [CodeProduitSemiFini] int  NOT NULL,
    [QuantiteProduitSemiFini] real  NOT NULL
);
GO

-- Creating table 'EveUtilisationRessources'
CREATE TABLE [dbo].[EveUtilisationRessources] (
    [CodeEmploye_Resp_production_] int  NOT NULL,
    [CodeEmploye_Resp_stock_matiere_premiere_] int  NOT NULL,
    [CodeUtilisationRessources] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'EveVentes'
CREATE TABLE [dbo].[EveVentes] (
    [CodeVente] int IDENTITY(1,1) NOT NULL,
    [CodeClient] int  NOT NULL,
    [CodeEmploye] int  NOT NULL,
    [DateVente] datetime  NOT NULL
);
GO

-- Creating table 'EveVenteStockProduitsFinis'
CREATE TABLE [dbo].[EveVenteStockProduitsFinis] (
    [CodeVente] int  NOT NULL,
    [CodeProduitFini] int  NOT NULL,
    [QuantiteProduitFini] int  NOT NULL,
    [Montant] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'ResComptesTresoreries'
CREATE TABLE [dbo].[ResComptesTresoreries] (
    [CodeCompte] int IDENTITY(1,1) NOT NULL,
    [NomCompte] nvarchar(50)  NOT NULL,
    [SoldeCompte] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'ResEquipementsInfrastructures'
CREATE TABLE [dbo].[ResEquipementsInfrastructures] (
    [CodeEquipementInfrastructure] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(50)  NOT NULL,
    [DateAcquisition] datetime  NOT NULL,
    [DureeDeVie] int  NOT NULL,
    [Quantite] int  NOT NULL,
    [MaterielDeProduction] bit  NOT NULL,
    [Montant] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'ResServicesFournitures'
CREATE TABLE [dbo].[ResServicesFournitures] (
    [CodeServiceFourniture] int IDENTITY(1,1) NOT NULL,
    [NomServiceFourniture] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ResStockMatieresPremieres'
CREATE TABLE [dbo].[ResStockMatieresPremieres] (
    [CodeMatierePremiere] int IDENTITY(1,1) NOT NULL,
    [NomMatiere] nvarchar(50)  NOT NULL,
    [StockMatiere] real  NOT NULL,
    [TypeMatiere] nvarchar(50)  NOT NULL,
    [CoutUnitaire] decimal(19,4)  NULL
);
GO

-- Creating table 'ResStockProduitsFinis'
CREATE TABLE [dbo].[ResStockProduitsFinis] (
    [CodeProduit] int IDENTITY(1,1) NOT NULL,
    [NomProduit] nvarchar(50)  NOT NULL,
    [StockProduit] int  NOT NULL,
    [PrixDeVenteStandard] int  NOT NULL,
    [CodeEmballage] int  NULL,
    [CoutUnitaire] int  NOT NULL
);
GO

-- Creating table 'ResStockProduitsSemiFinis'
CREATE TABLE [dbo].[ResStockProduitsSemiFinis] (
    [CodeProduitSemiFini] int IDENTITY(1,1) NOT NULL,
    [CodeMatierePremiere] int  NOT NULL,
    [Quantite] int  NOT NULL,
    [Description] nvarchar(50)  NOT NULL,
    [CoutUnitaire] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'EvePaiementEmployes'
CREATE TABLE [dbo].[EvePaiementEmployes] (
    [CodePaiementEmploye] int IDENTITY(1,1) NOT NULL,
    [CodeEmployePaye] int  NOT NULL,
    [DeCetteDate] datetime  NOT NULL,
    [ACetteDate] datetime  NOT NULL
);
GO

-- Creating table 'Utilisateurs'
CREATE TABLE [dbo].[Utilisateurs] (
    [CodeEmploye] int  NOT NULL,
    [NomUtilisateur] varchar(50)  NOT NULL,
    [MotDePasse] varchar(70)  NOT NULL,
    [Role] varchar(50)  NOT NULL
);
GO

-- Creating table 'EveEncaissementsAutres'
CREATE TABLE [dbo].[EveEncaissementsAutres] (
    [CodeEncaissementAutre] int IDENTITY(1,1) NOT NULL,
    [CodeEncaissement] int  NOT NULL,
    [DateEncaissement] datetime  NOT NULL,
    [Description] nvarchar(50)  NOT NULL,
    [MontantEncaisse] decimal(19,4)  NOT NULL,
    [FondsExternes] bit  NOT NULL
);
GO

-- Creating table 'EveReceptionDonsMatieresPremieres'
CREATE TABLE [dbo].[EveReceptionDonsMatieresPremieres] (
    [CodeReceptionDonMatierePremiere] int IDENTITY(1,1) NOT NULL,
    [CodeMatierePremiere] int  NOT NULL,
    [CodeEmploye] int  NOT NULL,
    [CodeFournisseur] int  NOT NULL,
    [DateReception] datetime  NOT NULL,
    [Quantite] float  NOT NULL
);
GO

-- Creating table 'EveSortieDechetsMatieresPremieres'
CREATE TABLE [dbo].[EveSortieDechetsMatieresPremieres] (
    [CodeSortieDechet] int  NOT NULL,
    [DateSortie] datetime  NOT NULL,
    [Description] nvarchar(50)  NOT NULL,
    [CodeMatierePremiere] int  NOT NULL,
    [QuantiteMatierePremiere] float  NOT NULL,
    [CodeEmploye_responsable_stock_] int  NOT NULL,
    [CodeEmploye_autre_responsable_] int  NOT NULL
);
GO

-- Creating table 'EveEncaissementsCreances'
CREATE TABLE [dbo].[EveEncaissementsCreances] (
    [CodeEncaissementCreance] int IDENTITY(1,1) NOT NULL,
    [CodeClient] int  NOT NULL,
    [MontantEncaisse] decimal(19,4)  NOT NULL,
    [DateEncaissement] datetime  NOT NULL,
    [CodeEncaissement] int  NOT NULL
);
GO

-- Creating table 'EveTransvasements'
CREATE TABLE [dbo].[EveTransvasements] (
    [CodeTransvasage] int IDENTITY(1,1) NOT NULL,
    [DateOperation] datetime  NOT NULL,
    [CodeEmballageInitial] int  NOT NULL,
    [QuantiteATransvaser] float  NOT NULL,
    [CodeEmballageFinal] int  NOT NULL,
    [CodeProduitInitial] int  NOT NULL,
    [CodeProduitFinal] int  NOT NULL
);
GO

-- Creating table 'EveUtilisationEquipementInfrastructures'
CREATE TABLE [dbo].[EveUtilisationEquipementInfrastructures] (
    [EveUtilisationRessources_CodeUtilisationRessources] int  NOT NULL,
    [ResEquipementsInfrastructures_CodeEquipementInfrastructure] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CodeAutreFournisseur] in table 'AgeAutreFournisseurs'
ALTER TABLE [dbo].[AgeAutreFournisseurs]
ADD CONSTRAINT [PK_AgeAutreFournisseurs]
    PRIMARY KEY CLUSTERED ([CodeAutreFournisseur] ASC);
GO

-- Creating primary key on [CodeClient] in table 'AgeClients'
ALTER TABLE [dbo].[AgeClients]
ADD CONSTRAINT [PK_AgeClients]
    PRIMARY KEY CLUSTERED ([CodeClient] ASC);
GO

-- Creating primary key on [CodeEmploye] in table 'AgeEmployes'
ALTER TABLE [dbo].[AgeEmployes]
ADD CONSTRAINT [PK_AgeEmployes]
    PRIMARY KEY CLUSTERED ([CodeEmploye] ASC);
GO

-- Creating primary key on [CodeFournisseurMatierePremiere] in table 'AgeFournisseursMatieresPremieres'
ALTER TABLE [dbo].[AgeFournisseursMatieresPremieres]
ADD CONSTRAINT [PK_AgeFournisseursMatieresPremieres]
    PRIMARY KEY CLUSTERED ([CodeFournisseurMatierePremiere] ASC);
GO

-- Creating primary key on [CodeFournisseurServiceFourniture] in table 'AgeFournisseursServicesFournitures'
ALTER TABLE [dbo].[AgeFournisseursServicesFournitures]
ADD CONSTRAINT [PK_AgeFournisseursServicesFournitures]
    PRIMARY KEY CLUSTERED ([CodeFournisseurServiceFourniture] ASC);
GO

-- Creating primary key on [CodeAcquisitionServiceFourniture] in table 'EveAcquisitionServicesFournitures'
ALTER TABLE [dbo].[EveAcquisitionServicesFournitures]
ADD CONSTRAINT [PK_EveAcquisitionServicesFournitures]
    PRIMARY KEY CLUSTERED ([CodeAcquisitionServiceFourniture] ASC);
GO

-- Creating primary key on [CodeDecaissement] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [PK_EveDecaissements]
    PRIMARY KEY CLUSTERED ([CodeDecaissement] ASC);
GO

-- Creating primary key on [CodeEncaissement] in table 'EveEncaissements'
ALTER TABLE [dbo].[EveEncaissements]
ADD CONSTRAINT [PK_EveEncaissements]
    PRIMARY KEY CLUSTERED ([CodeEncaissement] ASC);
GO

-- Creating primary key on [CodeEncaissement], [CodeVente] in table 'EveEncaissementsVentes'
ALTER TABLE [dbo].[EveEncaissementsVentes]
ADD CONSTRAINT [PK_EveEncaissementsVentes]
    PRIMARY KEY CLUSTERED ([CodeEncaissement], [CodeVente] ASC);
GO

-- Creating primary key on [CodePresence] in table 'EvePresenceEmployes'
ALTER TABLE [dbo].[EvePresenceEmployes]
ADD CONSTRAINT [PK_EvePresenceEmployes]
    PRIMARY KEY CLUSTERED ([CodePresence] ASC);
GO

-- Creating primary key on [CodeProduction], [CodeProduitSemiFini] in table 'EveProductionProduitsSemiFinis'
ALTER TABLE [dbo].[EveProductionProduitsSemiFinis]
ADD CONSTRAINT [PK_EveProductionProduitsSemiFinis]
    PRIMARY KEY CLUSTERED ([CodeProduction], [CodeProduitSemiFini] ASC);
GO

-- Creating primary key on [CodeProduction] in table 'EveProductions'
ALTER TABLE [dbo].[EveProductions]
ADD CONSTRAINT [PK_EveProductions]
    PRIMARY KEY CLUSTERED ([CodeProduction] ASC);
GO

-- Creating primary key on [CodeProduction], [CodeProduitFini] in table 'EveProductionStockProduitsFinis'
ALTER TABLE [dbo].[EveProductionStockProduitsFinis]
ADD CONSTRAINT [PK_EveProductionStockProduitsFinis]
    PRIMARY KEY CLUSTERED ([CodeProduction], [CodeProduitFini] ASC);
GO

-- Creating primary key on [CodeReceptionEquipementInfrastructure] in table 'EveReceptionEquipementsInfrastructures'
ALTER TABLE [dbo].[EveReceptionEquipementsInfrastructures]
ADD CONSTRAINT [PK_EveReceptionEquipementsInfrastructures]
    PRIMARY KEY CLUSTERED ([CodeReceptionEquipementInfrastructure] ASC);
GO

-- Creating primary key on [CodeReceptionMatierePremiere] in table 'EveReceptionMatieresPremieres'
ALTER TABLE [dbo].[EveReceptionMatieresPremieres]
ADD CONSTRAINT [PK_EveReceptionMatieresPremieres]
    PRIMARY KEY CLUSTERED ([CodeReceptionMatierePremiere] ASC);
GO

-- Creating primary key on [CodeUtilisationRessource], [CodeMatierePremiere] in table 'EveUtilisationMatieresPremieres'
ALTER TABLE [dbo].[EveUtilisationMatieresPremieres]
ADD CONSTRAINT [PK_EveUtilisationMatieresPremieres]
    PRIMARY KEY CLUSTERED ([CodeUtilisationRessource], [CodeMatierePremiere] ASC);
GO

-- Creating primary key on [CodeUtilisationRessource], [CodeProduitSemiFini] in table 'EveUtilisationProduitsSemiFinis'
ALTER TABLE [dbo].[EveUtilisationProduitsSemiFinis]
ADD CONSTRAINT [PK_EveUtilisationProduitsSemiFinis]
    PRIMARY KEY CLUSTERED ([CodeUtilisationRessource], [CodeProduitSemiFini] ASC);
GO

-- Creating primary key on [CodeUtilisationRessources] in table 'EveUtilisationRessources'
ALTER TABLE [dbo].[EveUtilisationRessources]
ADD CONSTRAINT [PK_EveUtilisationRessources]
    PRIMARY KEY CLUSTERED ([CodeUtilisationRessources] ASC);
GO

-- Creating primary key on [CodeVente] in table 'EveVentes'
ALTER TABLE [dbo].[EveVentes]
ADD CONSTRAINT [PK_EveVentes]
    PRIMARY KEY CLUSTERED ([CodeVente] ASC);
GO

-- Creating primary key on [CodeVente], [CodeProduitFini] in table 'EveVenteStockProduitsFinis'
ALTER TABLE [dbo].[EveVenteStockProduitsFinis]
ADD CONSTRAINT [PK_EveVenteStockProduitsFinis]
    PRIMARY KEY CLUSTERED ([CodeVente], [CodeProduitFini] ASC);
GO

-- Creating primary key on [CodeCompte] in table 'ResComptesTresoreries'
ALTER TABLE [dbo].[ResComptesTresoreries]
ADD CONSTRAINT [PK_ResComptesTresoreries]
    PRIMARY KEY CLUSTERED ([CodeCompte] ASC);
GO

-- Creating primary key on [CodeEquipementInfrastructure] in table 'ResEquipementsInfrastructures'
ALTER TABLE [dbo].[ResEquipementsInfrastructures]
ADD CONSTRAINT [PK_ResEquipementsInfrastructures]
    PRIMARY KEY CLUSTERED ([CodeEquipementInfrastructure] ASC);
GO

-- Creating primary key on [CodeServiceFourniture] in table 'ResServicesFournitures'
ALTER TABLE [dbo].[ResServicesFournitures]
ADD CONSTRAINT [PK_ResServicesFournitures]
    PRIMARY KEY CLUSTERED ([CodeServiceFourniture] ASC);
GO

-- Creating primary key on [CodeMatierePremiere] in table 'ResStockMatieresPremieres'
ALTER TABLE [dbo].[ResStockMatieresPremieres]
ADD CONSTRAINT [PK_ResStockMatieresPremieres]
    PRIMARY KEY CLUSTERED ([CodeMatierePremiere] ASC);
GO

-- Creating primary key on [CodeProduit] in table 'ResStockProduitsFinis'
ALTER TABLE [dbo].[ResStockProduitsFinis]
ADD CONSTRAINT [PK_ResStockProduitsFinis]
    PRIMARY KEY CLUSTERED ([CodeProduit] ASC);
GO

-- Creating primary key on [CodeProduitSemiFini] in table 'ResStockProduitsSemiFinis'
ALTER TABLE [dbo].[ResStockProduitsSemiFinis]
ADD CONSTRAINT [PK_ResStockProduitsSemiFinis]
    PRIMARY KEY CLUSTERED ([CodeProduitSemiFini] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [CodePaiementEmploye] in table 'EvePaiementEmployes'
ALTER TABLE [dbo].[EvePaiementEmployes]
ADD CONSTRAINT [PK_EvePaiementEmployes]
    PRIMARY KEY CLUSTERED ([CodePaiementEmploye] ASC);
GO

-- Creating primary key on [CodeEmploye] in table 'Utilisateurs'
ALTER TABLE [dbo].[Utilisateurs]
ADD CONSTRAINT [PK_Utilisateurs]
    PRIMARY KEY CLUSTERED ([CodeEmploye] ASC);
GO

-- Creating primary key on [CodeEncaissementAutre] in table 'EveEncaissementsAutres'
ALTER TABLE [dbo].[EveEncaissementsAutres]
ADD CONSTRAINT [PK_EveEncaissementsAutres]
    PRIMARY KEY CLUSTERED ([CodeEncaissementAutre] ASC);
GO

-- Creating primary key on [CodeReceptionDonMatierePremiere] in table 'EveReceptionDonsMatieresPremieres'
ALTER TABLE [dbo].[EveReceptionDonsMatieresPremieres]
ADD CONSTRAINT [PK_EveReceptionDonsMatieresPremieres]
    PRIMARY KEY CLUSTERED ([CodeReceptionDonMatierePremiere] ASC);
GO

-- Creating primary key on [CodeSortieDechet] in table 'EveSortieDechetsMatieresPremieres'
ALTER TABLE [dbo].[EveSortieDechetsMatieresPremieres]
ADD CONSTRAINT [PK_EveSortieDechetsMatieresPremieres]
    PRIMARY KEY CLUSTERED ([CodeSortieDechet] ASC);
GO

-- Creating primary key on [CodeEncaissementCreance] in table 'EveEncaissementsCreances'
ALTER TABLE [dbo].[EveEncaissementsCreances]
ADD CONSTRAINT [PK_EveEncaissementsCreances]
    PRIMARY KEY CLUSTERED ([CodeEncaissementCreance] ASC);
GO

-- Creating primary key on [CodeTransvasage] in table 'EveTransvasements'
ALTER TABLE [dbo].[EveTransvasements]
ADD CONSTRAINT [PK_EveTransvasements]
    PRIMARY KEY CLUSTERED ([CodeTransvasage] ASC);
GO

-- Creating primary key on [EveUtilisationRessources_CodeUtilisationRessources], [ResEquipementsInfrastructures_CodeEquipementInfrastructure] in table 'EveUtilisationEquipementInfrastructures'
ALTER TABLE [dbo].[EveUtilisationEquipementInfrastructures]
ADD CONSTRAINT [PK_EveUtilisationEquipementInfrastructures]
    PRIMARY KEY CLUSTERED ([EveUtilisationRessources_CodeUtilisationRessources], [ResEquipementsInfrastructures_CodeEquipementInfrastructure] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CodeAutreFournisseur] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_AgeAutreFournisseurs]
    FOREIGN KEY ([CodeAutreFournisseur])
    REFERENCES [dbo].[AgeAutreFournisseurs]
        ([CodeAutreFournisseur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_AgeAutreFournisseurs'
CREATE INDEX [IX_FK_EveDecaissements_AgeAutreFournisseurs]
ON [dbo].[EveDecaissements]
    ([CodeAutreFournisseur]);
GO

-- Creating foreign key on [CodeAutreFournisseur] in table 'EveReceptionEquipementsInfrastructures'
ALTER TABLE [dbo].[EveReceptionEquipementsInfrastructures]
ADD CONSTRAINT [FK_EveReceptionEquipementsInfrastructures_AgeAutreFournisseurs]
    FOREIGN KEY ([CodeAutreFournisseur])
    REFERENCES [dbo].[AgeAutreFournisseurs]
        ([CodeAutreFournisseur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionEquipementsInfrastructures_AgeAutreFournisseurs'
CREATE INDEX [IX_FK_EveReceptionEquipementsInfrastructures_AgeAutreFournisseurs]
ON [dbo].[EveReceptionEquipementsInfrastructures]
    ([CodeAutreFournisseur]);
GO

-- Creating foreign key on [CodeClient] in table 'EveVentes'
ALTER TABLE [dbo].[EveVentes]
ADD CONSTRAINT [FK_EveVentes_AgeClients]
    FOREIGN KEY ([CodeClient])
    REFERENCES [dbo].[AgeClients]
        ([CodeClient])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveVentes_AgeClients'
CREATE INDEX [IX_FK_EveVentes_AgeClients]
ON [dbo].[EveVentes]
    ([CodeClient]);
GO

-- Creating foreign key on [CodeEmploye] in table 'EveAcquisitionServicesFournitures'
ALTER TABLE [dbo].[EveAcquisitionServicesFournitures]
ADD CONSTRAINT [FK_EveAcquisitionServicesFournitures_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveAcquisitionServicesFournitures_AgeEmployes'
CREATE INDEX [IX_FK_EveAcquisitionServicesFournitures_AgeEmployes]
ON [dbo].[EveAcquisitionServicesFournitures]
    ([CodeEmploye]);
GO

-- Creating foreign key on [CodeEmploye] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_AgeEmployes'
CREATE INDEX [IX_FK_EveDecaissements_AgeEmployes]
ON [dbo].[EveDecaissements]
    ([CodeEmploye]);
GO

-- Creating foreign key on [CodeEmploye] in table 'EveEncaissements'
ALTER TABLE [dbo].[EveEncaissements]
ADD CONSTRAINT [FK_EveEncaissements_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveEncaissements_AgeEmployes'
CREATE INDEX [IX_FK_EveEncaissements_AgeEmployes]
ON [dbo].[EveEncaissements]
    ([CodeEmploye]);
GO

-- Creating foreign key on [CodeEmploye] in table 'EvePresenceEmployes'
ALTER TABLE [dbo].[EvePresenceEmployes]
ADD CONSTRAINT [FK_EvePresenceEmployes_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvePresenceEmployes_AgeEmployes'
CREATE INDEX [IX_FK_EvePresenceEmployes_AgeEmployes]
ON [dbo].[EvePresenceEmployes]
    ([CodeEmploye]);
GO

-- Creating foreign key on [CodeEmploye_Resp_stock_produits_finis] in table 'EveProductions'
ALTER TABLE [dbo].[EveProductions]
ADD CONSTRAINT [FK_EveProductions_AgeEmployes1]
    FOREIGN KEY ([CodeEmploye_Resp_stock_produits_finis])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveProductions_AgeEmployes1'
CREATE INDEX [IX_FK_EveProductions_AgeEmployes1]
ON [dbo].[EveProductions]
    ([CodeEmploye_Resp_stock_produits_finis]);
GO

-- Creating foreign key on [CodeEmploye] in table 'EveReceptionEquipementsInfrastructures'
ALTER TABLE [dbo].[EveReceptionEquipementsInfrastructures]
ADD CONSTRAINT [FK_EveReceptionEquipementsInfrastructures_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionEquipementsInfrastructures_AgeEmployes'
CREATE INDEX [IX_FK_EveReceptionEquipementsInfrastructures_AgeEmployes]
ON [dbo].[EveReceptionEquipementsInfrastructures]
    ([CodeEmploye]);
GO

-- Creating foreign key on [CodeEmploye] in table 'EveReceptionMatieresPremieres'
ALTER TABLE [dbo].[EveReceptionMatieresPremieres]
ADD CONSTRAINT [FK_EveReceptionMatieresPremieres_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionMatieresPremieres_AgeEmployes'
CREATE INDEX [IX_FK_EveReceptionMatieresPremieres_AgeEmployes]
ON [dbo].[EveReceptionMatieresPremieres]
    ([CodeEmploye]);
GO

-- Creating foreign key on [CodeEmploye_Resp_production_] in table 'EveUtilisationRessources'
ALTER TABLE [dbo].[EveUtilisationRessources]
ADD CONSTRAINT [FK_EveUtilisationRessources_AgeEmployes]
    FOREIGN KEY ([CodeEmploye_Resp_production_])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveUtilisationRessources_AgeEmployes'
CREATE INDEX [IX_FK_EveUtilisationRessources_AgeEmployes]
ON [dbo].[EveUtilisationRessources]
    ([CodeEmploye_Resp_production_]);
GO

-- Creating foreign key on [CodeEmploye_Resp_stock_matiere_premiere_] in table 'EveUtilisationRessources'
ALTER TABLE [dbo].[EveUtilisationRessources]
ADD CONSTRAINT [FK_EveUtilisationRessources_AgeEmployes1]
    FOREIGN KEY ([CodeEmploye_Resp_stock_matiere_premiere_])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveUtilisationRessources_AgeEmployes1'
CREATE INDEX [IX_FK_EveUtilisationRessources_AgeEmployes1]
ON [dbo].[EveUtilisationRessources]
    ([CodeEmploye_Resp_stock_matiere_premiere_]);
GO

-- Creating foreign key on [CodeEmploye] in table 'EveVentes'
ALTER TABLE [dbo].[EveVentes]
ADD CONSTRAINT [FK_EveVentes_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveVentes_AgeEmployes'
CREATE INDEX [IX_FK_EveVentes_AgeEmployes]
ON [dbo].[EveVentes]
    ([CodeEmploye]);
GO

-- Creating foreign key on [CodeFournisseurMatierePremiere] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_AgeFournisseursMatieresPremieres]
    FOREIGN KEY ([CodeFournisseurMatierePremiere])
    REFERENCES [dbo].[AgeFournisseursMatieresPremieres]
        ([CodeFournisseurMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_AgeFournisseursMatieresPremieres'
CREATE INDEX [IX_FK_EveDecaissements_AgeFournisseursMatieresPremieres]
ON [dbo].[EveDecaissements]
    ([CodeFournisseurMatierePremiere]);
GO

-- Creating foreign key on [CodeFournisseurMatierePremiere] in table 'EveReceptionMatieresPremieres'
ALTER TABLE [dbo].[EveReceptionMatieresPremieres]
ADD CONSTRAINT [FK_EveReceptionMatieresPremieres_AgeFournisseursMatieresPremieres]
    FOREIGN KEY ([CodeFournisseurMatierePremiere])
    REFERENCES [dbo].[AgeFournisseursMatieresPremieres]
        ([CodeFournisseurMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionMatieresPremieres_AgeFournisseursMatieresPremieres'
CREATE INDEX [IX_FK_EveReceptionMatieresPremieres_AgeFournisseursMatieresPremieres]
ON [dbo].[EveReceptionMatieresPremieres]
    ([CodeFournisseurMatierePremiere]);
GO

-- Creating foreign key on [CodeFournisseurServiceFourniture] in table 'EveAcquisitionServicesFournitures'
ALTER TABLE [dbo].[EveAcquisitionServicesFournitures]
ADD CONSTRAINT [FK_EveAcquisitionServicesFournitures_AgeFournisseursServicesFournitures]
    FOREIGN KEY ([CodeFournisseurServiceFourniture])
    REFERENCES [dbo].[AgeFournisseursServicesFournitures]
        ([CodeFournisseurServiceFourniture])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveAcquisitionServicesFournitures_AgeFournisseursServicesFournitures'
CREATE INDEX [IX_FK_EveAcquisitionServicesFournitures_AgeFournisseursServicesFournitures]
ON [dbo].[EveAcquisitionServicesFournitures]
    ([CodeFournisseurServiceFourniture]);
GO

-- Creating foreign key on [CodeFournisseurService] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_AgeFournisseursServicesFournitures]
    FOREIGN KEY ([CodeFournisseurService])
    REFERENCES [dbo].[AgeFournisseursServicesFournitures]
        ([CodeFournisseurServiceFourniture])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_AgeFournisseursServicesFournitures'
CREATE INDEX [IX_FK_EveDecaissements_AgeFournisseursServicesFournitures]
ON [dbo].[EveDecaissements]
    ([CodeFournisseurService]);
GO

-- Creating foreign key on [CodeServiceFourniture] in table 'EveAcquisitionServicesFournitures'
ALTER TABLE [dbo].[EveAcquisitionServicesFournitures]
ADD CONSTRAINT [FK_EveAcquisitionServicesFournitures_ResServicesFournitures]
    FOREIGN KEY ([CodeServiceFourniture])
    REFERENCES [dbo].[ResServicesFournitures]
        ([CodeServiceFourniture])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveAcquisitionServicesFournitures_ResServicesFournitures'
CREATE INDEX [IX_FK_EveAcquisitionServicesFournitures_ResServicesFournitures]
ON [dbo].[EveAcquisitionServicesFournitures]
    ([CodeServiceFourniture]);
GO

-- Creating foreign key on [CodeAcquisitionServiceFourniture] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_EveAcquisitionServicesFournitures]
    FOREIGN KEY ([CodeAcquisitionServiceFourniture])
    REFERENCES [dbo].[EveAcquisitionServicesFournitures]
        ([CodeAcquisitionServiceFourniture])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_EveAcquisitionServicesFournitures'
CREATE INDEX [IX_FK_EveDecaissements_EveAcquisitionServicesFournitures]
ON [dbo].[EveDecaissements]
    ([CodeAcquisitionServiceFourniture]);
GO

-- Creating foreign key on [CodeReceptionEquipementInfrastructure] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_EveReceptionEquipementsInfrastructures]
    FOREIGN KEY ([CodeReceptionEquipementInfrastructure])
    REFERENCES [dbo].[EveReceptionEquipementsInfrastructures]
        ([CodeReceptionEquipementInfrastructure])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_EveReceptionEquipementsInfrastructures'
CREATE INDEX [IX_FK_EveDecaissements_EveReceptionEquipementsInfrastructures]
ON [dbo].[EveDecaissements]
    ([CodeReceptionEquipementInfrastructure]);
GO

-- Creating foreign key on [CodeReceptionMatierePremiere] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_EveReceptionMatieresPremieres]
    FOREIGN KEY ([CodeReceptionMatierePremiere])
    REFERENCES [dbo].[EveReceptionMatieresPremieres]
        ([CodeReceptionMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_EveReceptionMatieresPremieres'
CREATE INDEX [IX_FK_EveDecaissements_EveReceptionMatieresPremieres]
ON [dbo].[EveDecaissements]
    ([CodeReceptionMatierePremiere]);
GO

-- Creating foreign key on [CodeCompte] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_ResComptesTresorerie]
    FOREIGN KEY ([CodeCompte])
    REFERENCES [dbo].[ResComptesTresoreries]
        ([CodeCompte])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_ResComptesTresorerie'
CREATE INDEX [IX_FK_EveDecaissements_ResComptesTresorerie]
ON [dbo].[EveDecaissements]
    ([CodeCompte]);
GO

-- Creating foreign key on [CodeCompte] in table 'EveEncaissements'
ALTER TABLE [dbo].[EveEncaissements]
ADD CONSTRAINT [FK_EveEncaissements_ResComptesTresorerie]
    FOREIGN KEY ([CodeCompte])
    REFERENCES [dbo].[ResComptesTresoreries]
        ([CodeCompte])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveEncaissements_ResComptesTresorerie'
CREATE INDEX [IX_FK_EveEncaissements_ResComptesTresorerie]
ON [dbo].[EveEncaissements]
    ([CodeCompte]);
GO

-- Creating foreign key on [CodeEncaissement] in table 'EveEncaissementsVentes'
ALTER TABLE [dbo].[EveEncaissementsVentes]
ADD CONSTRAINT [FK_EveEncaissementsVentes_EveEncaissements]
    FOREIGN KEY ([CodeEncaissement])
    REFERENCES [dbo].[EveEncaissements]
        ([CodeEncaissement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodeVente] in table 'EveEncaissementsVentes'
ALTER TABLE [dbo].[EveEncaissementsVentes]
ADD CONSTRAINT [FK_EveEncaissementsVentes_EveVentes]
    FOREIGN KEY ([CodeVente])
    REFERENCES [dbo].[EveVentes]
        ([CodeVente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveEncaissementsVentes_EveVentes'
CREATE INDEX [IX_FK_EveEncaissementsVentes_EveVentes]
ON [dbo].[EveEncaissementsVentes]
    ([CodeVente]);
GO

-- Creating foreign key on [CodeProduction] in table 'EveProductionProduitsSemiFinis'
ALTER TABLE [dbo].[EveProductionProduitsSemiFinis]
ADD CONSTRAINT [FK_EveProductionProduitsSemiFinis_EveProductions]
    FOREIGN KEY ([CodeProduction])
    REFERENCES [dbo].[EveProductions]
        ([CodeProduction])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodeProduitSemiFini] in table 'EveProductionProduitsSemiFinis'
ALTER TABLE [dbo].[EveProductionProduitsSemiFinis]
ADD CONSTRAINT [FK_EveProductionProduitsSemiFinis_ResStockProduitsSemiFinis]
    FOREIGN KEY ([CodeProduitSemiFini])
    REFERENCES [dbo].[ResStockProduitsSemiFinis]
        ([CodeProduitSemiFini])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveProductionProduitsSemiFinis_ResStockProduitsSemiFinis'
CREATE INDEX [IX_FK_EveProductionProduitsSemiFinis_ResStockProduitsSemiFinis]
ON [dbo].[EveProductionProduitsSemiFinis]
    ([CodeProduitSemiFini]);
GO

-- Creating foreign key on [CodeUtilisationRessources] in table 'EveProductions'
ALTER TABLE [dbo].[EveProductions]
ADD CONSTRAINT [FK_EveProductions_EveUtilisationRessources]
    FOREIGN KEY ([CodeUtilisationRessources])
    REFERENCES [dbo].[EveUtilisationRessources]
        ([CodeUtilisationRessources])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveProductions_EveUtilisationRessources'
CREATE INDEX [IX_FK_EveProductions_EveUtilisationRessources]
ON [dbo].[EveProductions]
    ([CodeUtilisationRessources]);
GO

-- Creating foreign key on [CodeProduction] in table 'EveProductionStockProduitsFinis'
ALTER TABLE [dbo].[EveProductionStockProduitsFinis]
ADD CONSTRAINT [FK_EveProductionStockProduitsFinis_EveProductions]
    FOREIGN KEY ([CodeProduction])
    REFERENCES [dbo].[EveProductions]
        ([CodeProduction])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodeProduitFini] in table 'EveProductionStockProduitsFinis'
ALTER TABLE [dbo].[EveProductionStockProduitsFinis]
ADD CONSTRAINT [FK_EveProductionStockProduitsFinis_ResStockProduitsFinis]
    FOREIGN KEY ([CodeProduitFini])
    REFERENCES [dbo].[ResStockProduitsFinis]
        ([CodeProduit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveProductionStockProduitsFinis_ResStockProduitsFinis'
CREATE INDEX [IX_FK_EveProductionStockProduitsFinis_ResStockProduitsFinis]
ON [dbo].[EveProductionStockProduitsFinis]
    ([CodeProduitFini]);
GO

-- Creating foreign key on [CodeEquipementInfrastructure] in table 'EveReceptionEquipementsInfrastructures'
ALTER TABLE [dbo].[EveReceptionEquipementsInfrastructures]
ADD CONSTRAINT [FK_EveReceptionEquipementsInfrastructures_ResEquipementsInfrastructures]
    FOREIGN KEY ([CodeEquipementInfrastructure])
    REFERENCES [dbo].[ResEquipementsInfrastructures]
        ([CodeEquipementInfrastructure])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionEquipementsInfrastructures_ResEquipementsInfrastructures'
CREATE INDEX [IX_FK_EveReceptionEquipementsInfrastructures_ResEquipementsInfrastructures]
ON [dbo].[EveReceptionEquipementsInfrastructures]
    ([CodeEquipementInfrastructure]);
GO

-- Creating foreign key on [CodeMatierePremiere] in table 'EveReceptionMatieresPremieres'
ALTER TABLE [dbo].[EveReceptionMatieresPremieres]
ADD CONSTRAINT [FK_EveReceptionMatieresPremieres_ResStockMatieresPremieres]
    FOREIGN KEY ([CodeMatierePremiere])
    REFERENCES [dbo].[ResStockMatieresPremieres]
        ([CodeMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionMatieresPremieres_ResStockMatieresPremieres'
CREATE INDEX [IX_FK_EveReceptionMatieresPremieres_ResStockMatieresPremieres]
ON [dbo].[EveReceptionMatieresPremieres]
    ([CodeMatierePremiere]);
GO

-- Creating foreign key on [CodeUtilisationRessource] in table 'EveUtilisationMatieresPremieres'
ALTER TABLE [dbo].[EveUtilisationMatieresPremieres]
ADD CONSTRAINT [FK_EveUtilisationMatieresPremieres_EveUtilisationRessources]
    FOREIGN KEY ([CodeUtilisationRessource])
    REFERENCES [dbo].[EveUtilisationRessources]
        ([CodeUtilisationRessources])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodeMatierePremiere] in table 'EveUtilisationMatieresPremieres'
ALTER TABLE [dbo].[EveUtilisationMatieresPremieres]
ADD CONSTRAINT [FK_EveUtilisationMatieresPremieres_ResStockMatieresPremieres]
    FOREIGN KEY ([CodeMatierePremiere])
    REFERENCES [dbo].[ResStockMatieresPremieres]
        ([CodeMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveUtilisationMatieresPremieres_ResStockMatieresPremieres'
CREATE INDEX [IX_FK_EveUtilisationMatieresPremieres_ResStockMatieresPremieres]
ON [dbo].[EveUtilisationMatieresPremieres]
    ([CodeMatierePremiere]);
GO

-- Creating foreign key on [CodeUtilisationRessource] in table 'EveUtilisationProduitsSemiFinis'
ALTER TABLE [dbo].[EveUtilisationProduitsSemiFinis]
ADD CONSTRAINT [FK_EveUtilisationProduitsSemiFinis_EveUtilisationRessources]
    FOREIGN KEY ([CodeUtilisationRessource])
    REFERENCES [dbo].[EveUtilisationRessources]
        ([CodeUtilisationRessources])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodeProduitSemiFini] in table 'EveUtilisationProduitsSemiFinis'
ALTER TABLE [dbo].[EveUtilisationProduitsSemiFinis]
ADD CONSTRAINT [FK_EveUtilisationProduitsSemiFinis_ResStockProduitsSemiFinis]
    FOREIGN KEY ([CodeProduitSemiFini])
    REFERENCES [dbo].[ResStockProduitsSemiFinis]
        ([CodeProduitSemiFini])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveUtilisationProduitsSemiFinis_ResStockProduitsSemiFinis'
CREATE INDEX [IX_FK_EveUtilisationProduitsSemiFinis_ResStockProduitsSemiFinis]
ON [dbo].[EveUtilisationProduitsSemiFinis]
    ([CodeProduitSemiFini]);
GO

-- Creating foreign key on [CodeVente] in table 'EveVenteStockProduitsFinis'
ALTER TABLE [dbo].[EveVenteStockProduitsFinis]
ADD CONSTRAINT [FK_EveVenteStockProduitsFinis_EveVentes]
    FOREIGN KEY ([CodeVente])
    REFERENCES [dbo].[EveVentes]
        ([CodeVente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodeProduitFini] in table 'EveVenteStockProduitsFinis'
ALTER TABLE [dbo].[EveVenteStockProduitsFinis]
ADD CONSTRAINT [FK_EveVenteStockProduitsFinis_ResStockProduitsFinis]
    FOREIGN KEY ([CodeProduitFini])
    REFERENCES [dbo].[ResStockProduitsFinis]
        ([CodeProduit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveVenteStockProduitsFinis_ResStockProduitsFinis'
CREATE INDEX [IX_FK_EveVenteStockProduitsFinis_ResStockProduitsFinis]
ON [dbo].[EveVenteStockProduitsFinis]
    ([CodeProduitFini]);
GO

-- Creating foreign key on [CodeMatierePremiere] in table 'ResStockProduitsSemiFinis'
ALTER TABLE [dbo].[ResStockProduitsSemiFinis]
ADD CONSTRAINT [FK_ResStockProduitsSemiFinis_ResStockMatieresPremieres]
    FOREIGN KEY ([CodeMatierePremiere])
    REFERENCES [dbo].[ResStockMatieresPremieres]
        ([CodeMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ResStockProduitsSemiFinis_ResStockMatieresPremieres'
CREATE INDEX [IX_FK_ResStockProduitsSemiFinis_ResStockMatieresPremieres]
ON [dbo].[ResStockProduitsSemiFinis]
    ([CodeMatierePremiere]);
GO

-- Creating foreign key on [CodeProduitSemiFini] in table 'ResStockProduitsSemiFinis'
ALTER TABLE [dbo].[ResStockProduitsSemiFinis]
ADD CONSTRAINT [FK_ResStockProduitsSemiFinis_ResStockProduitsSemiFinis]
    FOREIGN KEY ([CodeProduitSemiFini])
    REFERENCES [dbo].[ResStockProduitsSemiFinis]
        ([CodeProduitSemiFini])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EveUtilisationRessources_CodeUtilisationRessources] in table 'EveUtilisationEquipementInfrastructures'
ALTER TABLE [dbo].[EveUtilisationEquipementInfrastructures]
ADD CONSTRAINT [FK_EveUtilisationEquipementInfrastructures_EveUtilisationRessources]
    FOREIGN KEY ([EveUtilisationRessources_CodeUtilisationRessources])
    REFERENCES [dbo].[EveUtilisationRessources]
        ([CodeUtilisationRessources])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ResEquipementsInfrastructures_CodeEquipementInfrastructure] in table 'EveUtilisationEquipementInfrastructures'
ALTER TABLE [dbo].[EveUtilisationEquipementInfrastructures]
ADD CONSTRAINT [FK_EveUtilisationEquipementInfrastructures_ResEquipementsInfrastructures]
    FOREIGN KEY ([ResEquipementsInfrastructures_CodeEquipementInfrastructure])
    REFERENCES [dbo].[ResEquipementsInfrastructures]
        ([CodeEquipementInfrastructure])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveUtilisationEquipementInfrastructures_ResEquipementsInfrastructures'
CREATE INDEX [IX_FK_EveUtilisationEquipementInfrastructures_ResEquipementsInfrastructures]
ON [dbo].[EveUtilisationEquipementInfrastructures]
    ([ResEquipementsInfrastructures_CodeEquipementInfrastructure]);
GO

-- Creating foreign key on [CodeEmployePaye] in table 'EvePaiementEmployes'
ALTER TABLE [dbo].[EvePaiementEmployes]
ADD CONSTRAINT [FK_EvePaiementEmployes_AgeEmployes]
    FOREIGN KEY ([CodeEmployePaye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvePaiementEmployes_AgeEmployes'
CREATE INDEX [IX_FK_EvePaiementEmployes_AgeEmployes]
ON [dbo].[EvePaiementEmployes]
    ([CodeEmployePaye]);
GO

-- Creating foreign key on [CodePaiementEmploye] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_EvePaiementEmployes]
    FOREIGN KEY ([CodePaiementEmploye])
    REFERENCES [dbo].[EvePaiementEmployes]
        ([CodePaiementEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_EvePaiementEmployes'
CREATE INDEX [IX_FK_EveDecaissements_EvePaiementEmployes]
ON [dbo].[EveDecaissements]
    ([CodePaiementEmploye]);
GO

-- Creating foreign key on [CodeEmploye] in table 'Utilisateurs'
ALTER TABLE [dbo].[Utilisateurs]
ADD CONSTRAINT [FK_Utilisateurs_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodeClient] in table 'EveEncaissementsVentes'
ALTER TABLE [dbo].[EveEncaissementsVentes]
ADD CONSTRAINT [FK_EveEncaissementsVentes_AgeClients]
    FOREIGN KEY ([CodeClient])
    REFERENCES [dbo].[AgeClients]
        ([CodeClient])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveEncaissementsVentes_AgeClients'
CREATE INDEX [IX_FK_EveEncaissementsVentes_AgeClients]
ON [dbo].[EveEncaissementsVentes]
    ([CodeClient]);
GO

-- Creating foreign key on [CodeEncaissement] in table 'EveEncaissementsAutres'
ALTER TABLE [dbo].[EveEncaissementsAutres]
ADD CONSTRAINT [FK_EveEncaissementsAutres_EveEncaissements]
    FOREIGN KEY ([CodeEncaissement])
    REFERENCES [dbo].[EveEncaissements]
        ([CodeEncaissement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveEncaissementsAutres_EveEncaissements'
CREATE INDEX [IX_FK_EveEncaissementsAutres_EveEncaissements]
ON [dbo].[EveEncaissementsAutres]
    ([CodeEncaissement]);
GO

-- Creating foreign key on [CodeEmploye] in table 'EveReceptionDonsMatieresPremieres'
ALTER TABLE [dbo].[EveReceptionDonsMatieresPremieres]
ADD CONSTRAINT [FK_EveReceptionDonsMatieresPremieres_AgeEmployes]
    FOREIGN KEY ([CodeEmploye])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionDonsMatieresPremieres_AgeEmployes'
CREATE INDEX [IX_FK_EveReceptionDonsMatieresPremieres_AgeEmployes]
ON [dbo].[EveReceptionDonsMatieresPremieres]
    ([CodeEmploye]);
GO

-- Creating foreign key on [CodeFournisseur] in table 'EveReceptionDonsMatieresPremieres'
ALTER TABLE [dbo].[EveReceptionDonsMatieresPremieres]
ADD CONSTRAINT [FK_EveReceptionDonsMatieresPremieres_AgeFournisseursMatieresPremieres]
    FOREIGN KEY ([CodeFournisseur])
    REFERENCES [dbo].[AgeFournisseursMatieresPremieres]
        ([CodeFournisseurMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionDonsMatieresPremieres_AgeFournisseursMatieresPremieres'
CREATE INDEX [IX_FK_EveReceptionDonsMatieresPremieres_AgeFournisseursMatieresPremieres]
ON [dbo].[EveReceptionDonsMatieresPremieres]
    ([CodeFournisseur]);
GO

-- Creating foreign key on [CodeMatierePremiere] in table 'EveReceptionDonsMatieresPremieres'
ALTER TABLE [dbo].[EveReceptionDonsMatieresPremieres]
ADD CONSTRAINT [FK_EveReceptionDonsMatieresPremieres_ResStockMatieresPremieres]
    FOREIGN KEY ([CodeMatierePremiere])
    REFERENCES [dbo].[ResStockMatieresPremieres]
        ([CodeMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveReceptionDonsMatieresPremieres_ResStockMatieresPremieres'
CREATE INDEX [IX_FK_EveReceptionDonsMatieresPremieres_ResStockMatieresPremieres]
ON [dbo].[EveReceptionDonsMatieresPremieres]
    ([CodeMatierePremiere]);
GO

-- Creating foreign key on [CodeReceptionDonMatierePremiere] in table 'EveDecaissements'
ALTER TABLE [dbo].[EveDecaissements]
ADD CONSTRAINT [FK_EveDecaissements_EveReceptionDonsMatieresPremieres]
    FOREIGN KEY ([CodeReceptionDonMatierePremiere])
    REFERENCES [dbo].[EveReceptionDonsMatieresPremieres]
        ([CodeReceptionDonMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveDecaissements_EveReceptionDonsMatieresPremieres'
CREATE INDEX [IX_FK_EveDecaissements_EveReceptionDonsMatieresPremieres]
ON [dbo].[EveDecaissements]
    ([CodeReceptionDonMatierePremiere]);
GO

-- Creating foreign key on [CodeEmploye_responsable_stock_] in table 'EveSortieDechetsMatieresPremieres'
ALTER TABLE [dbo].[EveSortieDechetsMatieresPremieres]
ADD CONSTRAINT [FK_EveSortieDechetsMatieresPremieres_AgeEmployes]
    FOREIGN KEY ([CodeEmploye_responsable_stock_])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveSortieDechetsMatieresPremieres_AgeEmployes'
CREATE INDEX [IX_FK_EveSortieDechetsMatieresPremieres_AgeEmployes]
ON [dbo].[EveSortieDechetsMatieresPremieres]
    ([CodeEmploye_responsable_stock_]);
GO

-- Creating foreign key on [CodeEmploye_autre_responsable_] in table 'EveSortieDechetsMatieresPremieres'
ALTER TABLE [dbo].[EveSortieDechetsMatieresPremieres]
ADD CONSTRAINT [FK_EveSortieDechetsMatieresPremieres_AgeEmployes1]
    FOREIGN KEY ([CodeEmploye_autre_responsable_])
    REFERENCES [dbo].[AgeEmployes]
        ([CodeEmploye])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveSortieDechetsMatieresPremieres_AgeEmployes1'
CREATE INDEX [IX_FK_EveSortieDechetsMatieresPremieres_AgeEmployes1]
ON [dbo].[EveSortieDechetsMatieresPremieres]
    ([CodeEmploye_autre_responsable_]);
GO

-- Creating foreign key on [CodeMatierePremiere] in table 'EveSortieDechetsMatieresPremieres'
ALTER TABLE [dbo].[EveSortieDechetsMatieresPremieres]
ADD CONSTRAINT [FK_EveSortieDechetsMatieresPremieres_ResStockMatieresPremieres]
    FOREIGN KEY ([CodeMatierePremiere])
    REFERENCES [dbo].[ResStockMatieresPremieres]
        ([CodeMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveSortieDechetsMatieresPremieres_ResStockMatieresPremieres'
CREATE INDEX [IX_FK_EveSortieDechetsMatieresPremieres_ResStockMatieresPremieres]
ON [dbo].[EveSortieDechetsMatieresPremieres]
    ([CodeMatierePremiere]);
GO

-- Creating foreign key on [CodeEmballage] in table 'ResStockProduitsFinis'
ALTER TABLE [dbo].[ResStockProduitsFinis]
ADD CONSTRAINT [FK_ResStockProduitsFinis_ResStockMatieresPremieresEmballages]
    FOREIGN KEY ([CodeEmballage])
    REFERENCES [dbo].[ResStockMatieresPremieres]
        ([CodeMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ResStockProduitsFinis_ResStockMatieresPremieresEmballages'
CREATE INDEX [IX_FK_ResStockProduitsFinis_ResStockMatieresPremieresEmballages]
ON [dbo].[ResStockProduitsFinis]
    ([CodeEmballage]);
GO

-- Creating foreign key on [CodeProduit] in table 'ResStockProduitsFinis'
ALTER TABLE [dbo].[ResStockProduitsFinis]
ADD CONSTRAINT [FK_ResStockProduitsFinis_ResStockProduitsFinis]
    FOREIGN KEY ([CodeProduit])
    REFERENCES [dbo].[ResStockProduitsFinis]
        ([CodeProduit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodeClient] in table 'EveEncaissementsCreances'
ALTER TABLE [dbo].[EveEncaissementsCreances]
ADD CONSTRAINT [FK_EveEncaissementsCreances_AgeClients]
    FOREIGN KEY ([CodeClient])
    REFERENCES [dbo].[AgeClients]
        ([CodeClient])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveEncaissementsCreances_AgeClients'
CREATE INDEX [IX_FK_EveEncaissementsCreances_AgeClients]
ON [dbo].[EveEncaissementsCreances]
    ([CodeClient]);
GO

-- Creating foreign key on [CodeEncaissement] in table 'EveEncaissementsCreances'
ALTER TABLE [dbo].[EveEncaissementsCreances]
ADD CONSTRAINT [FK_EveEncaissementsCreances_EveEncaissements]
    FOREIGN KEY ([CodeEncaissement])
    REFERENCES [dbo].[EveEncaissements]
        ([CodeEncaissement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveEncaissementsCreances_EveEncaissements'
CREATE INDEX [IX_FK_EveEncaissementsCreances_EveEncaissements]
ON [dbo].[EveEncaissementsCreances]
    ([CodeEncaissement]);
GO

-- Creating foreign key on [CodeEmballageFinal] in table 'EveTransvasements'
ALTER TABLE [dbo].[EveTransvasements]
ADD CONSTRAINT [FK_EveTransvasements_ResStockMatieresPremieres_Final]
    FOREIGN KEY ([CodeEmballageFinal])
    REFERENCES [dbo].[ResStockMatieresPremieres]
        ([CodeMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveTransvasements_ResStockMatieresPremieres_Final'
CREATE INDEX [IX_FK_EveTransvasements_ResStockMatieresPremieres_Final]
ON [dbo].[EveTransvasements]
    ([CodeEmballageFinal]);
GO

-- Creating foreign key on [CodeEmballageInitial] in table 'EveTransvasements'
ALTER TABLE [dbo].[EveTransvasements]
ADD CONSTRAINT [FK_EveTransvasements_ResStockMatieresPremieres_Initial]
    FOREIGN KEY ([CodeEmballageInitial])
    REFERENCES [dbo].[ResStockMatieresPremieres]
        ([CodeMatierePremiere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveTransvasements_ResStockMatieresPremieres_Initial'
CREATE INDEX [IX_FK_EveTransvasements_ResStockMatieresPremieres_Initial]
ON [dbo].[EveTransvasements]
    ([CodeEmballageInitial]);
GO

-- Creating foreign key on [CodeProduitFinal] in table 'EveTransvasements'
ALTER TABLE [dbo].[EveTransvasements]
ADD CONSTRAINT [FK_EveTransvasements_ResStockProduitsFinis_Final]
    FOREIGN KEY ([CodeProduitFinal])
    REFERENCES [dbo].[ResStockProduitsFinis]
        ([CodeProduit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveTransvasements_ResStockProduitsFinis_Final'
CREATE INDEX [IX_FK_EveTransvasements_ResStockProduitsFinis_Final]
ON [dbo].[EveTransvasements]
    ([CodeProduitFinal]);
GO

-- Creating foreign key on [CodeProduitInitial] in table 'EveTransvasements'
ALTER TABLE [dbo].[EveTransvasements]
ADD CONSTRAINT [FK_EveTransvasements_ResStockProduitsFinis_Initial]
    FOREIGN KEY ([CodeProduitInitial])
    REFERENCES [dbo].[ResStockProduitsFinis]
        ([CodeProduit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EveTransvasements_ResStockProduitsFinis_Initial'
CREATE INDEX [IX_FK_EveTransvasements_ResStockProduitsFinis_Initial]
ON [dbo].[EveTransvasements]
    ([CodeProduitInitial]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------