using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;
using CasaEcologie.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaEcologie.Services;

public class CompteDeResultatService : ICompteDeResultatService
{
    private readonly CasaDbContext _db;
    private readonly ICoutService _coutService;

    public CompteDeResultatService(CasaDbContext db, ICoutService coutService)
    {
        _db = db;
        _coutService = coutService;
    }

    public CompteDeResultatData GenererCompteDeResultat(DateTime debut, DateTime fin)
    {
        var data = new CompteDeResultatData();

        data.ChiffreDAffaires = CalculerVentesPeriode(debut, fin);
        data.CoutDesProduitsVendus = _coutService.CoutDeProduction(debut, fin);
        data.MargeBrute = data.ChiffreDAffaires - data.CoutDesProduitsVendus;

        data.Salaires = (decimal)MainDOeuvre(debut, fin);
        data.ServicesExterieurs = DepenseService(debut, fin, "Services extérieurs");
        data.Fournitures = DepenseService(debut, fin, "Fournitures");
        data.ReparationsEtMaintenance = DepenseService(debut, fin, "Réparations et maintenance");
        data.Location = DepenseService(debut, fin, "Location");
        data.TelephoneEtInternet = DepenseService(debut, fin, "Téléphone et internet");
        data.ElectriciteEtEau = DepenseService(debut, fin, "Eau et éléctricité");
        data.InteretsPayes = DepenseService(debut, fin, "Intérêts payés");
        data.FraisBancaires = DepenseService(debut, fin, "Frais bancaires");
        data.AutresTransport = DepenseService(debut, fin, "Transport (autre que matière première)");

        data.Taxes = ImpotsEtTaxesDeLaPeriode(debut, fin);
        data.Amortissements = (decimal)AmortissementsDeLaPeriode(debut, fin);

        decimal fraisGeneraux = FraisGenerauxDeLaPeriode(debut, fin);
        decimal resultatAvantImpotsEtAmortissements = data.MargeBrute + data.AutresRevenus - fraisGeneraux;

        data.TotalCharges = data.CoutDesProduitsVendus + fraisGeneraux + data.Amortissements + data.Taxes;
        data.ResultatNet = resultatAvantImpotsEtAmortissements - data.Amortissements - data.Taxes;

        return data;
    }

    internal decimal CalculerVentesPeriode(DateTime debut, DateTime fin)
    {
        return (from v in _db.EveVentes
                join vp in _db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                where v.DateVente >= debut && v.DateVente <= fin
                select (decimal?)vp.Montant).Sum() ?? 0m;
    }

    internal float CumulVentes(DateTime date)
    {
        return (from v in _db.EveVentes
                join vp in _db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                where v.DateVente <= date
                select (float?)vp.Montant).Sum() ?? 0;
    }

    internal decimal FraisGenerauxDeLaPeriode(DateTime debut, DateTime fin)
    {
        var fraisGeneraux = _db.EveDecaissements
            .Where(d => d.DateDecaissement >= debut.Date && d.DateDecaissement <= fin.Date)
            .Where(d => d.CodeAcquisitionServiceFourniture != null)
            .Where(d => d.EveAcquisitionServicesFourniture!.ResServicesFourniture.NomServiceFourniture != "Taxes")
            .Where(d => d.EveAcquisitionServicesFourniture!.ResServicesFourniture.NomServiceFourniture != "Retrait des propriétaires")
            .Select(d => (float?)d.Montant).Sum() ?? 0f;

        return (decimal)(fraisGeneraux + MainDOeuvre(debut, fin));
    }

    internal decimal ImpotsEtTaxesDeLaPeriode(DateTime debut, DateTime fin)
    {
        return (from asf in _db.EveAcquisitionServicesFournitures
                where asf.Date >= debut.Date
                where asf.Date <= fin.Date
                where asf.ResServicesFourniture.NomServiceFourniture == "Taxes"
                select (decimal?)asf.Montant).Sum() ?? 0m;
    }

    internal float MainDOeuvre(DateTime debut, DateTime fin)
    {
        return (from mo in _db.EveDecaissements
                where mo.CodePaiementEmploye != null
                where mo.DateDecaissement >= debut.Date
                where mo.DateDecaissement <= fin.Date
                select (float?)mo.Montant).Sum() ?? 0f;
    }

    internal float AmortissementsDeLaPeriode(DateTime debut, DateTime fin)
    {
        return (from inE in _db.ResEquipementsInfrastructures
                where (inE.DateAcquisition.Year + inE.DureeDeVie) > debut.Year
                select new
                {
                    inE.Montant,
                    inE.DureeDeVie,
                    nombreJoursPeriode = EF.Functions.DateDiffDay(debut, fin),
                })
                .Select(a => (float?)((float)a.Montant / (a.DureeDeVie * 365.0f)) * a.nombreJoursPeriode)
                .Sum() ?? 0f;
    }

    private decimal DepenseService(DateTime debut, DateTime fin, string typeDepense)
    {
        return (from sf in _db.EveAcquisitionServicesFournitures
                join d in _db.EveDecaissements on sf.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                where sf.ResServicesFourniture.NomServiceFourniture == typeDepense
                where d.DateDecaissement >= debut.Date
                where d.DateDecaissement <= fin.Date
                select (decimal?)d.Montant).Sum() ?? 0m;
    }
}
