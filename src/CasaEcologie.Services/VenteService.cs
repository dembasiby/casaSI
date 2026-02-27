using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;

namespace CasaEcologie.Services;

public class VenteService : IVenteService
{
    private readonly CasaDbContext _db;
    private readonly ICoutService _coutService;

    public VenteService(CasaDbContext db, ICoutService coutService)
    {
        _db = db;
        _coutService = coutService;
    }

    public decimal CalculerChiffreDAffaires(DateTime debut, DateTime fin)
    {
        return (from v in _db.EveVentes
                join vp in _db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                where v.DateVente >= debut && v.DateVente <= fin
                select (decimal?)vp.Montant).Sum() ?? 0m;
    }

    public decimal CalculerCoutDesProduitsVendus(DateTime debut, DateTime fin)
    {
        return _coutService.CoutDeProduction(debut, fin);
    }
}
