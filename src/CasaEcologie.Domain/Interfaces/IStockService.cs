using CasaEcologie.Domain.Models;

namespace CasaEcologie.Domain.Interfaces;

public interface IStockService
{
    float CalculerSoldeStockMatierePremiere(string nomMatiere, DateTime date);
    int CalculerSoldeStockProduitFini(string produitFini, DateTime date);
    int CalculerSoldeStockProduitSemiFini(string produitSemiFini, DateTime date);
    float CoutUnitaireParMatierePremiere(string nomMatiere);
    float ValeurAchatsMatierePremiere(string nomMatiere, DateTime debut, DateTime fin);
    decimal QuantiteMatierePremiereParProduitFini(string nomProduit, string matierePremiere);
    decimal QuantiteMatierePremiereParProduitSemiFini(string produitSemiFini, string matierePremiere);
    decimal QuantiteProduitSemiFiniParProduitFini(string nomProduit, string produitSemiFini);
    float CalculerCoutUnitaireMatierePremiere(string matiere);
    List<StockMovementRow> CalculerSoldeStocksDeFaconProgressive(List<StockMovementRow> rows, float stockInitial);
    float ValeurTotalDesStocks(DateTime date);
}
