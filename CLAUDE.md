# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

CasaEcologieSysInfo is a Windows Forms ERP/management application for **Casa Écologie**, an ecological products manufacturing company. The application handles inventory, production, sales, purchasing, treasury, employee management, and financial statements. The UI and all business terminology are in **French**.

## Solution Structure (New .NET 10 Rewrite)

```
CasaEcologieSysInfo.sln           ← Legacy .NET Framework 4.8 project
src/
├── CasaEcologie.Domain/          ← Class library: entities, DTOs, service interfaces
├── CasaEcologie.Data/            ← Class library: EF Core DbContext, Fluent API configurations
├── CasaEcologie.Services/        ← Class library: business logic implementations
└── CasaEcologie.WinForms/        ← WinForms app: UI only, composition root
```

**Dependency flow**: WinForms → Services → Data → Domain (+ WinForms → Domain for DTOs)

## Build & Run

### New Solution (src/)
- **Build all**: `dotnet build src/CasaEcologie.WinForms/CasaEcologie.WinForms.csproj`
- **Build single project**: `dotnet build src/CasaEcologie.Domain/CasaEcologie.Domain.csproj`
- **Run**: `dotnet run --project src/CasaEcologie.WinForms/CasaEcologie.WinForms.csproj`
- **Target**: .NET 10 (net10.0 / net10.0-windows)
- **Database**: SQL Server Express (`.\SQLEXPRESS`), database `CasaDB2`, Windows integrated auth
- **Connection string**: `src/CasaEcologie.WinForms/appsettings.json`
- **No test project exists** yet

### Legacy Solution
- **Build**: `msbuild CasaEcologieSysInfo.sln`
- **Target**: .NET Framework 4.8
- **Data**: Entity Framework 6 Database First via `Model3.edmx`

## Architecture (New)

### Domain Layer (`src/CasaEcologie.Domain/`)
- **Entities/** — 35 POCO entity classes (clean, no EF dependencies)
- **Models/** — DTOs for financial statements: `BilanData`, `CompteDeResultatData`, `TresorerieData`, `StockMovementRow`, etc.
- **Interfaces/** — Service contracts: `IStockService`, `ITresorerieService`, `IBilanService`, `ICompteDeResultatService`, `ICoutService`, `IVenteService`, `IProductionService`, `IAuthService`, `IValidationService`

### Data Layer (`src/CasaEcologie.Data/`)
- **CasaDbContext** — EF Core DbContext with 35 DbSets, uses `ApplyConfigurationsFromAssembly`
- **Configurations/** — Fluent API configs per entity group (AgeConfigurations, EveVenteConfigurations, ResConfigurations, etc.)
- Special column names with parentheses mapped via `HasColumnName()`: e.g. `"CodeEmploye(Resp production)"`
- Composite keys on junction tables: `EveVenteStockProduitsFinis`, `EveProductionProduitsSemiFinis`, etc.
- FK column name mismatches resolved with `HasPrincipalKey()`: e.g. `CodeProduitFini → CodeProduit`

### Services Layer (`src/CasaEcologie.Services/`)
- All services receive `CasaDbContext` (and other service interfaces) via constructor injection
- **StockService** — stock balance calculations, unit costs, stock valuation
- **CoutService** — cost of materials consumed, cost of production, inventory valuation
- **TresorerieService** — treasury balance, receivables, payables, full treasury report
- **BilanService** — balance sheet generation with depreciation calculations
- **CompteDeResultatService** — income statement with `EF.Functions.DateDiffDay()` for depreciation
- **VenteService** — revenue and COGS calculations
- **AuthService** — BCrypt password hashing/verification
- **ValidationService** — pure validation returning `(bool IsValid, string ErrorMessage)` (no MessageBox)

### WinForms Layer (`src/CasaEcologie.WinForms/`)
- **Program.cs** — composition root: reads `appsettings.json`, creates `ServiceContainer`, launches login form
- **ServiceContainer** — holds all service instances, passed to forms
- **Formulaires/** — `FrmConnexion` (login), `FrmAccueil` (main shell with sidebar → pnlPrincipal pattern)
- Each page receives `ServiceContainer` in constructor

### Naming Conventions for Entities
- **`Age*`** (Agent): Actors — clients, employees, suppliers
- **`Eve*`** (Événement): Events/transactions — purchases, sales, production, payments
- **`Res*`** (Ressource): Resources/inventory — stock items, treasury accounts, equipment

## Important Notes
- The fiscal start date is hardcoded as `new DateTime(2019, 1, 1)` in financial calculations
- Stock balances are computed from initial stock + entries - exits (no snapshot table)
- Commit messages are written in **French**
- Money columns use `HasColumnType("money")` in EF Core configurations
- `EF.Functions.DateDiffDay()` replaces EF6's `DbFunctions.DiffDays()`
- Legacy `Model3.edmx` and auto-generated files in `CasaEcologieSysInfo/` should not be manually edited
