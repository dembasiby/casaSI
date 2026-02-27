namespace CasaEcologie.Domain.Interfaces;

public interface IProductionService
{
    List<DateTime> ObtenirListeDatesProduction();
    string ObtenirEtiquetteProduit(string nomProduit);
}
