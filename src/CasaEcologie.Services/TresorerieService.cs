using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;
using CasaEcologie.Domain.Models;

namespace CasaEcologie.Services;

public class TresorerieService : ITresorerieService
{
    private readonly CasaDbContext _db;

    public TresorerieService(CasaDbContext db)
    {
        _db = db;
    }

    public string CalculerSoldeTresorerie(DateTime debutPeriode)
    {
        var soldeInitiaux = _db.ResComptesTresoreries
            .Select(c => (decimal?)c.SoldeCompte).Sum() ?? 0m;

        var totalEncaissements = (from c in _db.EveEncaissements
                                  from env in _db.EveEncaissementsVentes
                                  where c.CodeEncaissement == env.CodeEncaissement
                                  where env.DateEncaissement < debutPeriode.Date
                                  select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

        var encaissementCreance = (from c in _db.EveEncaissements
                                   from env in _db.EveEncaissementsCreances
                                   where c.CodeEncaissement == env.CodeEncaissement
                                   where env.DateEncaissement < debutPeriode
                                   select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

        var totalAutresEn = (from enc in _db.EveEncaissements
                             from aut in _db.EveEncaissementsAutres
                             where enc.CodeEncaissement == aut.CodeEncaissement
                             where aut.DateEncaissement < debutPeriode.Date
                             select (decimal?)aut.MontantEncaisse).Sum() ?? 0m;

        var totalDecaissements = _db.EveDecaissements
            .Where(d => d.DateDecaissement < debutPeriode.Date)
            .Select(d => (decimal?)d.Montant).Sum() ?? 0m;

        var fondsDisponible = soldeInitiaux + totalEncaissements + totalAutresEn + encaissementCreance - totalDecaissements;
        return fondsDisponible.ToString("n0");
    }

    public TresorerieData GenererRapportTresorerie(DateTime debut, DateTime fin)
    {
        var data = new TresorerieData();

        data.FondsDisponibleEnDebutDePeriode = CalculerSoldeTresorerie(debut);
        data.VentesEnCash = TotalVentesCashPeriode(debut, fin);
        data.RemboursementCreances = RemboursementCreances(debut, fin);
        data.PretsEtAutresFondsRecus = PretEtAutresFondsRecus(debut, fin);

        decimal totalRecettes = decimal.Parse(data.VentesEnCash) + decimal.Parse(data.RemboursementCreances) + decimal.Parse(data.PretsEtAutresFondsRecus);
        data.TotalRecettesTresorerie = totalRecettes.ToString("n0");

        decimal fondsAvantDepenses = decimal.Parse(data.FondsDisponibleEnDebutDePeriode) + totalRecettes;
        data.TotalFondsDisponibles = fondsAvantDepenses.ToString("n0");

        data.AchatMatieresPremieres = AchatMatieresPremieres(debut, fin);
        data.AchatEmballages = AchatEmballage(debut, fin);
        data.Salaires = PaiementSalaires(debut, fin);
        data.ServicesExterieurs = DepenseServiceFourniture(debut, fin, "Services extérieurs");
        data.Fournitures = DepenseServiceFourniture(debut, fin, "Fournitures");
        data.ReparationsEtMaintenance = DepenseServiceFourniture(debut, fin, "Réparations et maintenance");
        data.Location = DepenseServiceFourniture(debut, fin, "Location");
        data.TelephoneEtInternet = DepenseServiceFourniture(debut, fin, "Téléphone et internet");
        data.ElectriciteEtEau = DepenseServiceFourniture(debut, fin, "Eau et éléctricité");
        data.Taxes = DepenseServiceFourniture(debut, fin, "Taxes");
        data.InteretsPayes = DepenseServiceFourniture(debut, fin, "Intérêts payés");
        data.FraisBancaires = DepenseServiceFourniture(debut, fin, "Frais bancaires");
        data.AutresTransport = DepenseServiceFourniture(debut, fin, "Transport (autre que matière première)");

        decimal sousTotal = decimal.Parse(data.AchatMatieresPremieres) + decimal.Parse(data.AchatEmballages)
            + decimal.Parse(data.Salaires) + decimal.Parse(data.ServicesExterieurs)
            + decimal.Parse(data.Fournitures) + decimal.Parse(data.ReparationsEtMaintenance)
            + decimal.Parse(data.Location) + decimal.Parse(data.TelephoneEtInternet)
            + decimal.Parse(data.ElectriciteEtEau) + decimal.Parse(data.Taxes)
            + decimal.Parse(data.InteretsPayes) + decimal.Parse(data.FraisBancaires)
            + decimal.Parse(data.AutresTransport);
        data.SousTotalDepenses = sousTotal.ToString("n0");

        data.PaiementPrincipal = DepenseServiceFourniture(debut, fin, "Paiement des écheances de prêt (principal)");
        data.InvestissementsDeLaPeriode = InvestissementsDeLaPeriode(debut, fin);
        data.RetraitDesProprietaires = DepenseServiceFourniture(debut, fin, "Retrait des propriétaires");

        decimal totalDepenses = sousTotal + decimal.Parse(data.PaiementPrincipal)
            + decimal.Parse(data.InvestissementsDeLaPeriode) + decimal.Parse(data.RetraitDesProprietaires);
        data.TotalDepensesTresorerie = totalDepenses.ToString("n0");

        data.TresorerieDisponibleEnFinDePeriode = (fondsAvantDepenses - totalDepenses).ToString("n0");

        return data;
    }

    public decimal CalculerTotalCreancesClients()
    {
        var ventesClients = (from c in _db.AgeClients
                             from vf in _db.EveVenteStockProduitsFinis
                             from v in _db.EveVentes
                             where v.CodeClient == c.CodeClient
                             where vf.CodeVente == v.CodeVente
                             select (decimal?)vf.Montant).Sum() ?? 0m;

        var totalPaiementClient = (from c in _db.AgeClients
                                   from ev in _db.EveEncaissementsVentes
                                   where c.CodeClient == ev.CodeClient
                                   select (decimal?)ev.MontantEncaisse).Sum() ?? 0m;

        var encaissementCreances = (from c in _db.AgeClients
                                    from ec in _db.EveEncaissementsCreances
                                    where c.CodeClient == ec.CodeClient
                                    select (decimal?)ec.MontantEncaisse).Sum() ?? 0m;

        var creanceInitialClient = _db.AgeClients
            .Select(c => (decimal?)c.SoldeInitialeCreance).Sum() ?? 0m;

        return creanceInitialClient + ventesClients - totalPaiementClient - encaissementCreances;
    }

    public decimal CalculerSoldeCreanceClient(int codeClient)
    {
        var ventesClients = (from c in _db.AgeClients
                             join v in _db.EveVentes on c.CodeClient equals v.CodeClient
                             join vpf in _db.EveVenteStockProduitsFinis on v.CodeVente equals vpf.CodeVente
                             where c.CodeClient == codeClient
                             select (decimal?)vpf.Montant).Sum() ?? 0m;

        var totalPaiementClient = (from c in _db.AgeClients
                                   join ev in _db.EveEncaissementsVentes on c.CodeClient equals ev.CodeClient
                                   where c.CodeClient == codeClient
                                   select (decimal?)ev.MontantEncaisse).Sum() ?? 0m;

        var encaissementCreances = (from c in _db.AgeClients
                                    join ecc in _db.EveEncaissementsCreances on c.CodeClient equals ecc.CodeClient
                                    where c.CodeClient == codeClient
                                    select (decimal?)ecc.MontantEncaisse).Sum() ?? 0m;

        var creanceInitialClient = _db.AgeClients
            .Where(c => c.CodeClient == codeClient)
            .Select(c => (decimal?)c.SoldeInitialeCreance).Sum() ?? 0m;

        return creanceInitialClient + ventesClients - totalPaiementClient - encaissementCreances;
    }

    public float CalculerTotalCreancesClientsALaDateDu(DateTime date)
    {
        var ventesClients = (from c in _db.AgeClients
                             from vf in _db.EveVenteStockProduitsFinis
                             from v in _db.EveVentes
                             where v.CodeClient == c.CodeClient
                             where vf.CodeVente == v.CodeVente
                             where v.DateVente <= date
                             select (float?)vf.Montant).Sum() ?? 0f;

        var totalPaiementClient = (from c in _db.AgeClients
                                   from ev in _db.EveEncaissementsVentes
                                   where c.CodeClient == ev.CodeClient
                                   where ev.DateEncaissement <= date
                                   select (float?)ev.MontantEncaisse).Sum() ?? 0f;

        var encaissementCreances = (from c in _db.AgeClients
                                    from ec in _db.EveEncaissementsCreances
                                    where c.CodeClient == ec.CodeClient
                                    where ec.DateEncaissement <= date
                                    select (float?)ec.MontantEncaisse).Sum() ?? 0f;

        var creanceInitialClient = _db.AgeClients
            .Select(c => (float?)c.SoldeInitialeCreance).Sum() ?? 0f;

        return creanceInitialClient + ventesClients - totalPaiementClient - encaissementCreances;
    }

    public decimal CalculerTotalDettesFournisseurs()
    {
        var soldeInitial = _db.AgeFournisseursMatieresPremieres
            .Select(fmp => (decimal?)fmp.SoldeDette).Sum() ?? 0m;
        var totalAchats = (from f in _db.AgeFournisseursMatieresPremieres
                           join rmp in _db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                           select (decimal?)rmp.Montant).Sum() ?? 0m;
        var totalPaiements = (from fmp in _db.AgeFournisseursMatieresPremieres
                              join d in _db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                              select (decimal?)d.Montant).Sum() ?? 0m;

        var soldeInitialFE = _db.AgeAutreFournisseurs
            .Select(f => (decimal?)f.SoldeInitialDetteFournisseur).Sum() ?? 0m;
        var totalAchatsFE = (from f in _db.AgeAutreFournisseurs
                             join rmp in _db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                             join ei in _db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                             select (decimal?)ei.Montant).Sum() ?? 0m;
        var totalPaiementsFE = (from f in _db.AgeAutreFournisseurs
                                join d in _db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                select (decimal?)d.Montant).Sum() ?? 0m;

        var soldeInitialFS = _db.AgeFournisseursServicesFournitures
            .Select(f => (decimal?)f.SoldeDette).Sum() ?? 0m;
        var totalAchatsFS = (from f in _db.AgeFournisseursServicesFournitures
                             join rmp in _db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                             select (decimal?)rmp.Montant).Sum() ?? 0m;
        var totalPaiementsFS = (from f in _db.EveAcquisitionServicesFournitures
                                join d in _db.EveDecaissements on f.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                                select (decimal?)d.Montant).Sum() ?? 0m;

        return soldeInitial + soldeInitialFE + soldeInitialFS
            + totalAchats + totalAchatsFE + totalAchatsFS
            - totalPaiements - totalPaiementsFE - totalPaiementsFS;
    }

    public decimal CalculerTotalDettesFournisseursALaDateDu(DateTime date)
    {
        var soldeInitial = _db.AgeFournisseursMatieresPremieres
            .Select(fmp => (decimal?)fmp.SoldeDette).Sum() ?? 0m;
        var totalAchats = (from f in _db.AgeFournisseursMatieresPremieres
                           join rmp in _db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                           where rmp.DateReception <= date
                           select (decimal?)rmp.Montant).Sum() ?? 0m;
        var totalPaiements = (from fmp in _db.AgeFournisseursMatieresPremieres
                              join d in _db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                              where d.DateDecaissement <= date
                              select (decimal?)d.Montant).Sum() ?? 0m;

        var soldeInitialFE = _db.AgeAutreFournisseurs
            .Select(f => (decimal?)f.SoldeInitialDetteFournisseur).Sum() ?? 0m;
        var totalAchatsFE = (from f in _db.AgeAutreFournisseurs
                             join rmp in _db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                             join ei in _db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                             where ei.DateAcquisition <= date
                             select (decimal?)ei.Montant).Sum() ?? 0m;
        var totalPaiementsFE = (from f in _db.AgeAutreFournisseurs
                                join d in _db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                where d.DateDecaissement <= date
                                select (decimal?)d.Montant).Sum() ?? 0m;

        var soldeInitialFS = _db.AgeFournisseursServicesFournitures
            .Select(f => (decimal?)f.SoldeDette).Sum() ?? 0m;
        var totalAchatsFS = (from f in _db.AgeFournisseursServicesFournitures
                             join rmp in _db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                             where rmp.Date <= date
                             select (decimal?)rmp.Montant).Sum() ?? 0m;
        var totalPaiementsFS = (from f in _db.EveAcquisitionServicesFournitures
                                join d in _db.EveDecaissements on f.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                                where d.DateDecaissement <= date
                                select (decimal?)d.Montant).Sum() ?? 0m;

        return soldeInitial + soldeInitialFE + soldeInitialFS
            + totalAchats + totalAchatsFE + totalAchatsFS
            - totalPaiements - totalPaiementsFE - totalPaiementsFS;
    }

    public decimal CalculerTotalDettesFournisseurMatierePremiere(int codeFournisseur)
    {
        var soldeInitial = _db.AgeFournisseursMatieresPremieres
            .Where(fmp => fmp.CodeFournisseurMatierePremiere == codeFournisseur)
            .Select(fmp => (decimal?)fmp.SoldeDette).Sum() ?? 0m;

        var totalAchats = (from fmp in _db.AgeFournisseursMatieresPremieres
                           join rmp in _db.EveReceptionMatieresPremieres on fmp.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                           where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                           select (decimal?)rmp.Montant).Sum() ?? 0m;

        var totalPaiements = (from fmp in _db.AgeFournisseursMatieresPremieres
                              join d in _db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                              where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                              select (decimal?)d.Montant).Sum() ?? 0m;

        return soldeInitial + totalAchats - totalPaiements;
    }

    public decimal CalculerTotalDettesFournisseurEquipementsInfrastructures(int codeFournisseur)
    {
        var soldeInitialFE = _db.AgeAutreFournisseurs
            .Where(f => f.CodeAutreFournisseur == codeFournisseur)
            .Select(f => (decimal?)f.SoldeInitialDetteFournisseur).Sum() ?? 0m;

        var totalAchatsFE = (from f in _db.AgeAutreFournisseurs
                             join rmp in _db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                             join ei in _db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                             where f.CodeAutreFournisseur == codeFournisseur
                             select (decimal?)ei.Montant).Sum() ?? 0m;

        var totalPaiementsFE = (from f in _db.AgeAutreFournisseurs
                                join d in _db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                where f.CodeAutreFournisseur == codeFournisseur
                                select (decimal?)d.Montant).Sum() ?? 0m;

        return soldeInitialFE + totalAchatsFE - totalPaiementsFE;
    }

    public decimal CalculerTotalDettesFournisseurServicesFournitures(int codeFournisseur)
    {
        var soldeInitialFS = _db.AgeFournisseursServicesFournitures
            .Where(f => f.CodeFournisseurServiceFourniture == codeFournisseur)
            .Select(f => (decimal?)f.SoldeDette).Sum() ?? 0m;

        var totalAchatsFS = (from f in _db.AgeFournisseursServicesFournitures
                             join rmp in _db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                             where f.CodeFournisseurServiceFourniture == codeFournisseur
                             select (decimal?)rmp.Montant).Sum() ?? 0m;

        var totalPaiementsFS = (from f in _db.EveAcquisitionServicesFournitures
                                join d in _db.EveDecaissements on f.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                                where f.CodeFournisseurServiceFourniture == codeFournisseur
                                select (decimal?)d.Montant).Sum() ?? 0m;

        return soldeInitialFS + totalAchatsFS - totalPaiementsFS;
    }

    public decimal SoldeDisponibleDuCompteDeTresorerie(string nomCompte)
    {
        var soldeInitial = _db.ResComptesTresoreries
            .Where(c => c.NomCompte == nomCompte)
            .Select(c => c.SoldeCompte)
            .FirstOrDefault();

        var totalEncaissements = (from c in _db.EveEncaissements
                                  join nc in _db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                  where nc.NomCompte == nomCompte
                                  from env in _db.EveEncaissementsVentes
                                  where c.CodeEncaissement == env.CodeEncaissement
                                  select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

        var encaissementCreances = (from c in _db.EveEncaissements
                                    join nc in _db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                    where nc.NomCompte == nomCompte
                                    from enc in _db.EveEncaissementsCreances
                                    where c.CodeEncaissement == enc.CodeEncaissement
                                    select (decimal?)enc.MontantEncaisse).Sum() ?? 0m;

        var totalAutresEncaissement = (from c in _db.EveEncaissements
                                       join nc in _db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                       where nc.NomCompte == nomCompte
                                       from enA in _db.EveEncaissementsAutres
                                       where c.CodeEncaissement == enA.CodeEncaissement
                                       select (decimal?)enA.MontantEncaisse).Sum() ?? 0m;

        var totalDecaissements = _db.EveDecaissements
            .Where(d => d.ResComptesTresorerie.NomCompte == nomCompte)
            .Select(d => (decimal?)d.Montant).Sum() ?? 0m;

        return soldeInitial + totalEncaissements + encaissementCreances + totalAutresEncaissement - totalDecaissements;
    }

    public bool IlYaAssezDeFondsDansLeCompte(string nomCompte, decimal montant)
    {
        var soldeCompte = SoldeDisponibleDuCompteDeTresorerie(nomCompte);
        return montant < soldeCompte && soldeCompte > 0m;
    }

    public decimal CalculerSoldeDetteParFournisseur(int codeFournisseur)
    {
        var soldeInitial = _db.AgeFournisseursMatieresPremieres
            .Where(fmp => fmp.CodeFournisseurMatierePremiere == codeFournisseur)
            .Select(fmp => fmp.SoldeDette)
            .FirstOrDefault();

        var totalAchats = (from f in _db.AgeFournisseursMatieresPremieres
                           where f.CodeFournisseurMatierePremiere == codeFournisseur
                           join rmp in _db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                           select (decimal?)rmp.Montant).Sum() ?? 0m;

        var totalPaiements = (from fmp in _db.AgeFournisseursMatieresPremieres
                              where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                              join d in _db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                              select (decimal?)d.Montant).Sum() ?? 0m;

        var soldeInitialFE = _db.AgeAutreFournisseurs
            .Where(f => f.CodeAutreFournisseur == codeFournisseur)
            .Select(f => f.SoldeInitialDetteFournisseur)
            .FirstOrDefault();

        var totalAchatsFE = (from f in _db.AgeAutreFournisseurs
                             where f.CodeAutreFournisseur == codeFournisseur
                             join rmp in _db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                             join ei in _db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                             select (decimal?)ei.Montant).Sum() ?? 0m;

        var totalPaiementsFE = (from f in _db.AgeAutreFournisseurs
                                where f.CodeAutreFournisseur == codeFournisseur
                                join d in _db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                select (decimal?)d.Montant).Sum() ?? 0m;

        var soldeInitialFS = _db.AgeFournisseursServicesFournitures
            .Where(f => f.CodeFournisseurServiceFourniture == codeFournisseur)
            .Select(f => f.SoldeDette)
            .FirstOrDefault();

        var totalAchatsFS = (from f in _db.AgeFournisseursServicesFournitures
                             where f.CodeFournisseurServiceFourniture == codeFournisseur
                             join rmp in _db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                             select (decimal?)rmp.Montant).Sum() ?? 0m;

        var totalPaiementsFS = (from f in _db.AgeFournisseursServicesFournitures
                                where f.CodeFournisseurServiceFourniture == codeFournisseur
                                join d in _db.EveDecaissements on f.CodeFournisseurServiceFourniture equals d.CodeFournisseurService
                                select (decimal?)d.Montant).Sum() ?? 0m;

        return soldeInitial + soldeInitialFE + soldeInitialFS
            + totalAchats + totalAchatsFE + totalAchatsFS
            - totalPaiements - totalPaiementsFE - totalPaiementsFS;
    }

    private string TotalVentesCashPeriode(DateTime debut, DateTime fin)
    {
        var ventesCash = _db.EveEncaissementsVentes
            .Where(ev => ev.DateEncaissement >= debut.Date)
            .Where(ev => ev.DateEncaissement <= fin.Date)
            .Select(ev => (decimal?)ev.MontantEncaisse).Sum() ?? 0m;

        return ventesCash.ToString("n0");
    }

    private string RemboursementCreances(DateTime debut, DateTime fin)
    {
        var remboursements = _db.EveEncaissementsCreances
            .Where(r => r.DateEncaissement >= debut.Date)
            .Where(r => r.DateEncaissement <= fin.Date)
            .Select(r => (float?)r.MontantEncaisse).Sum() ?? 0;

        return remboursements.ToString("n0");
    }

    private string PretEtAutresFondsRecus(DateTime debut, DateTime fin)
    {
        var autresFondsRecus = _db.EveEncaissementsAutres
            .Where(aenc => aenc.FondsExternes)
            .Where(aenc => aenc.DateEncaissement >= debut.Date)
            .Where(aenc => aenc.DateEncaissement <= fin.Date)
            .Select(aenc => (decimal?)aenc.MontantEncaisse).Sum() ?? 0m;

        return autresFondsRecus.ToString("n0");
    }

    private string AchatMatieresPremieres(DateTime debut, DateTime fin)
    {
        float achatMP = (from amp in _db.EveReceptionMatieresPremieres
                         join d in _db.EveDecaissements on amp.CodeReceptionMatierePremiere equals d.CodeReceptionMatierePremiere
                         join mp in _db.ResStockMatieresPremieres on amp.CodeMatierePremiere equals mp.CodeMatierePremiere
                         where (mp.TypesMatiere.NomType == "Fruit" || mp.TypesMatiere.NomType == "Sucre")
                         where d.DateDecaissement >= debut.Date
                         where d.DateDecaissement <= fin.Date
                         select (float?)d.Montant).Sum() ?? 0;

        float remboursementDettes = (from d in _db.EveDecaissements
                                     where d.CodeFournisseurMatierePremiere != null
                                     where d.CodeReceptionMatierePremiere == null
                                     where d.DateDecaissement >= debut.Date
                                     where d.DateDecaissement <= fin.Date
                                     select (float?)d.Montant).Sum() ?? 0;

        float gaz = float.Parse(DepenseServiceFourniture(debut, fin, "Gaz"));

        return (achatMP + remboursementDettes + gaz).ToString("n0");
    }

    private string AchatEmballage(DateTime debut, DateTime fin)
    {
        float achatEmballages = (from amp in _db.EveReceptionMatieresPremieres
                                 join d in _db.EveDecaissements on amp.CodeReceptionMatierePremiere equals d.CodeReceptionMatierePremiere
                                 join mp in _db.ResStockMatieresPremieres on amp.CodeMatierePremiere equals mp.CodeMatierePremiere
                                 where (mp.TypesMatiere.NomType == "Emballage" || mp.TypesMatiere.NomType == "Sachet" || mp.TypesMatiere.NomType == "Etiquette")
                                 where d.DateDecaissement >= debut.Date
                                 where d.DateDecaissement <= fin.Date
                                 select (float?)d.Montant).Sum() ?? 0;

        return achatEmballages.ToString("n0");
    }

    private string PaiementSalaires(DateTime debut, DateTime fin)
    {
        float paiementSalaires = (from ps in _db.EvePaiementEmployes
                                  join d in _db.EveDecaissements on ps.CodePaiementEmploye equals d.CodePaiementEmploye
                                  where d.DateDecaissement >= debut.Date
                                  where d.DateDecaissement <= fin.Date
                                  select (float?)d.Montant).Sum() ?? 0;

        float autresSalaires = float.Parse(DepenseServiceFourniture(debut, fin, "Autres Salaires"));

        return (paiementSalaires + autresSalaires).ToString("n0");
    }

    private string InvestissementsDeLaPeriode(DateTime debut, DateTime fin)
    {
        decimal investissements = _db.EveDecaissements
            .Where(d => d.CodeReceptionEquipementInfrastructure != null)
            .Where(d => d.DateDecaissement >= debut.Date)
            .Where(d => d.DateDecaissement <= fin.Date)
            .Select(d => (decimal?)d.Montant).Sum() ?? 0m;

        return investissements.ToString("n0");
    }

    private string DepenseServiceFourniture(DateTime debut, DateTime fin, string typeDepense)
    {
        decimal depense = (from sf in _db.EveAcquisitionServicesFournitures
                           join d in _db.EveDecaissements on sf.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                           where sf.ResServicesFourniture.NomServiceFourniture == typeDepense
                           where d.DateDecaissement >= debut.Date
                           where d.DateDecaissement <= fin.Date
                           select (decimal?)d.Montant).Sum() ?? 0m;

        return depense.ToString("n0");
    }
}
