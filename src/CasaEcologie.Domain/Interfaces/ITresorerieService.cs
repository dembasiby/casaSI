using CasaEcologie.Domain.Models;

namespace CasaEcologie.Domain.Interfaces;

public interface ITresorerieService
{
    string CalculerSoldeTresorerie(DateTime debutPeriode);
    TresorerieData GenererRapportTresorerie(DateTime debut, DateTime fin);
    decimal CalculerTotalCreancesClients();
    decimal CalculerSoldeCreanceClient(int codeClient);
    float CalculerTotalCreancesClientsALaDateDu(DateTime date);
    decimal CalculerTotalDettesFournisseurs();
    decimal CalculerTotalDettesFournisseursALaDateDu(DateTime date);
    decimal CalculerTotalDettesFournisseurMatierePremiere(int codeFournisseur);
    decimal CalculerTotalDettesFournisseurEquipementsInfrastructures(int codeFournisseur);
    decimal CalculerTotalDettesFournisseurServicesFournitures(int codeFournisseur);
    decimal SoldeDisponibleDuCompteDeTresorerie(string nomCompte);
    bool IlYaAssezDeFondsDansLeCompte(string nomCompte, decimal montant);
    decimal CalculerSoldeDetteParFournisseur(int codeFournisseur);
}
