using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;
using CasaEcologie.Services;
using Microsoft.EntityFrameworkCore;

namespace CasaEcologie.WinForms;

public class ServiceContainer
{
    public CasaDbContext Db { get; }
    public IAuthService Auth { get; }
    public IValidationService Validation { get; }
    public IStockService Stock { get; }
    public ICoutService Cout { get; }
    public IVenteService Vente { get; }
    public IProductionService Production { get; }
    public ITresorerieService Tresorerie { get; }
    public IBilanService Bilan { get; }
    public ICompteDeResultatService CompteDeResultat { get; }

    public ServiceContainer(string connectionString)
    {
        var optionsBuilder = new Microsoft.EntityFrameworkCore.DbContextOptionsBuilder<CasaDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        Db = new CasaDbContext(optionsBuilder.Options);

        Validation = new ValidationService();
        Auth = new AuthService(Db);
        Stock = new StockService(Db);
        Cout = new CoutService(Db, Stock);
        Vente = new VenteService(Db, Cout);
        Production = new ProductionService(Db);
        Tresorerie = new TresorerieService(Db);

        var compteDeResultatService = new CompteDeResultatService(Db, Cout);
        CompteDeResultat = compteDeResultatService;
        Bilan = new BilanService(Db, Tresorerie, Stock, Cout, compteDeResultatService);
    }
}
