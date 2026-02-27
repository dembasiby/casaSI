using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;

namespace CasaEcologie.Services;

public class ProductionService : IProductionService
{
    private readonly CasaDbContext _db;

    public ProductionService(CasaDbContext db)
    {
        _db = db;
    }

    public List<DateTime> ObtenirListeDatesProduction()
    {
        return _db.EveProductions
            .Select(p => p.Date)
            .Distinct()
            .OrderBy(d => d)
            .ToList();
    }

    public string ObtenirEtiquetteProduit(string nomProduit)
    {
        if (nomProduit.StartsWith("sachet", StringComparison.OrdinalIgnoreCase) ||
            nomProduit.StartsWith("pastille", StringComparison.OrdinalIgnoreCase))
        {
            return string.Empty;
        }

        return nomProduit;
    }
}
