namespace CasaEcologie.Domain.Interfaces;

public interface IVenteService
{
    decimal CalculerChiffreDAffaires(DateTime debut, DateTime fin);
    decimal CalculerCoutDesProduitsVendus(DateTime debut, DateTime fin);
}
