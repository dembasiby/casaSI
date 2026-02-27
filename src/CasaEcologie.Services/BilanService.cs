using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;
using CasaEcologie.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaEcologie.Services;

public class BilanService : IBilanService
{
    private readonly CasaDbContext _db;
    private readonly ITresorerieService _tresorerieService;
    private readonly IStockService _stockService;
    private readonly ICoutService _coutService;
    private readonly CompteDeResultatService _compteDeResultatService;

    public BilanService(
        CasaDbContext db,
        ITresorerieService tresorerieService,
        IStockService stockService,
        ICoutService coutService,
        CompteDeResultatService compteDeResultatService)
    {
        _db = db;
        _tresorerieService = tresorerieService;
        _stockService = stockService;
        _coutService = coutService;
        _compteDeResultatService = compteDeResultatService;
    }

    public BilanData GenererBilan(DateTime debut, DateTime fin)
    {
        var data = new BilanData();

        // Actif
        data.Tresorerie = decimal.Parse(_tresorerieService.CalculerSoldeTresorerie(fin.AddDays(1)));
        data.CreancesClients = (decimal)_tresorerieService.CalculerTotalCreancesClientsALaDateDu(fin);
        data.StocksMatieresPremieres = (decimal)_coutService.ValeurStockMatieresPremieres(fin);
        data.StocksProduitsFinis = (decimal)_coutService.ValeurStockProduitsFinis(fin);
        data.StocksProduitsSemiFinis = (decimal)_coutService.ValeurStockProduitsSemiFinis(fin);
        data.TotalStocks = data.StocksMatieresPremieres + data.StocksProduitsFinis + data.StocksProduitsSemiFinis;
        data.TotalActifCirculant = data.Tresorerie + data.CreancesClients + data.TotalStocks;

        data.ImmobilisationsBrutes = (decimal)ImmobilisationsBrutes(fin);
        data.Amortissements = (decimal)AmortissementsCumules(fin);
        data.ImmobilisationsNettes = data.ImmobilisationsBrutes - data.Amortissements;
        data.TotalActif = data.TotalActifCirculant + data.ImmobilisationsNettes;

        // Passif
        data.DettesFournisseurs = _tresorerieService.CalculerTotalDettesFournisseursALaDateDu(fin);
        data.AutresDettes = 0;
        data.TotalDettes = data.DettesFournisseurs + data.AutresDettes;

        data.Capital = (decimal)CapitauxPropres(fin);
        data.ResultatNet = (decimal)BeneficesNonRepartis(fin);
        data.TotalCapitauxPropres = data.Capital + data.ResultatNet + (decimal)BeneficesRepartis(fin);
        data.TotalPassif = data.TotalCapitauxPropres + data.TotalDettes;

        return data;
    }

    private float ImmobilisationsBrutes(DateTime date)
    {
        return (from inE in _db.ResEquipementsInfrastructures
                where (inE.DateAcquisition.Year + inE.DureeDeVie) >= date.Year
                where inE.DateAcquisition <= date
                select (float?)inE.Montant).Sum() ?? 0f;
    }

    private float AmortissementsCumules(DateTime date)
    {
        var datePlusUn = date.AddDays(1);

        float amortNonAmortis = (from inE in _db.ResEquipementsInfrastructures
                                  where (inE.DateAcquisition.Year + inE.DureeDeVie) > datePlusUn.Year
                                  where inE.DateAcquisition < datePlusUn
                                  select new
                                  {
                                      inE.Montant,
                                      nombreJours = EF.Functions.DateDiffDay(inE.DateAcquisition, datePlusUn),
                                      inE.DureeDeVie,
                                  })
                                 .Select(a => (float?)((float)a.Montant / (a.DureeDeVie * 365.0f)) * a.nombreJours)
                                 .Sum() ?? 0f;

        float amortAmortis = _db.ResEquipementsInfrastructures
            .Where(inE => (inE.DateAcquisition.Year + inE.DureeDeVie) <= datePlusUn.Year)
            .Select(inE => (float?)inE.Montant).Sum() ?? 0f;

        return amortNonAmortis + amortAmortis;
    }

    private float CapitauxPropres(DateTime date)
    {
        DateTime debutFiscal = new DateTime(2019, 1, 1);

        float investissements = (from inE in _db.ResEquipementsInfrastructures
                                  where (inE.DateAcquisition.Year + inE.DureeDeVie) >= date.Year
                                  where inE.DateAcquisition <= date
                                  select (float?)inE.Montant).Sum() ?? 0f;

        float dettesFournisseurs = (float)_tresorerieService.CalculerTotalDettesFournisseursALaDateDu(date);
        float tresorerie = float.Parse(_tresorerieService.CalculerSoldeTresorerie(date.AddDays(1)));
        float stocks = _stockService.ValeurTotalDesStocks(date);
        float creances = _tresorerieService.CalculerTotalCreancesClientsALaDateDu(date);
        float impotsEtTaxes = (float)_compteDeResultatService.ImpotsEtTaxesDeLaPeriode(debutFiscal, date);

        return investissements + tresorerie + creances + stocks - dettesFournisseurs
            - ResultatAvantImpotsEtTaxes(date) + impotsEtTaxes;
    }

    private float BeneficesRepartis(DateTime date)
    {
        return (from br in _db.EveAcquisitionServicesFournitures
                where br.ResServicesFourniture.NomServiceFourniture == "Retrait des propriétaires"
                where br.Date <= date
                select (float?)br.Montant).Sum() ?? 0;
    }

    private float ResultatAvantImpotsEtTaxes(DateTime date)
    {
        DateTime debutFiscal = new DateTime(2019, 1, 1);
        float ventes = _compteDeResultatService.CumulVentes(date);
        float coutDesProduitsVendus = (float)_coutService.CoutDeProduction(debutFiscal, date);
        float fraisGeneraux = (float)_compteDeResultatService.FraisGenerauxDeLaPeriode(debutFiscal, date);

        return ventes - coutDesProduitsVendus - fraisGeneraux;
    }

    private float BeneficeNet(DateTime date)
    {
        DateTime debutFiscal = new DateTime(2019, 1, 1);
        float amortissements = AmortissementsCumules(date);
        float impotsEtTaxes = (float)_compteDeResultatService.ImpotsEtTaxesDeLaPeriode(debutFiscal, date);

        return ResultatAvantImpotsEtTaxes(date) - amortissements - impotsEtTaxes;
    }

    private float BeneficesNonRepartis(DateTime date)
    {
        return BeneficeNet(date) - BeneficesRepartis(date);
    }
}
