namespace CasaEcologie.Domain.Models;

public class BilanData
{
    // Actif
    public decimal Tresorerie { get; set; }
    public decimal CreancesClients { get; set; }
    public decimal StocksMatieresPremieres { get; set; }
    public decimal StocksProduitsFinis { get; set; }
    public decimal StocksProduitsSemiFinis { get; set; }
    public decimal TotalStocks { get; set; }
    public decimal TotalActifCirculant { get; set; }
    public decimal ImmobilisationsBrutes { get; set; }
    public decimal Amortissements { get; set; }
    public decimal ImmobilisationsNettes { get; set; }
    public decimal TotalActif { get; set; }

    // Passif
    public decimal DettesFournisseurs { get; set; }
    public decimal AutresDettes { get; set; }
    public decimal TotalDettes { get; set; }
    public decimal Capital { get; set; }
    public decimal ResultatNet { get; set; }
    public decimal TotalCapitauxPropres { get; set; }
    public decimal TotalPassif { get; set; }
}
