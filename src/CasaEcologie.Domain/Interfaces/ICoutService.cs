namespace CasaEcologie.Domain.Interfaces;

public interface ICoutService
{
    // Coût d'achat des matières premières
    decimal CoutDAchatMatieresPremieresConsommees(DateTime debut, DateTime fin);

    // Coût de production
    decimal CoutDeProduction(DateTime debut, DateTime fin);

    // Inventaires et valorisation
    float ValeurStockMatieresPremieres(DateTime date);
    float ValeurStockProduitsFinis(DateTime date);
    float ValeurStockProduitsSemiFinis(DateTime date);
}
