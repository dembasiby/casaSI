namespace CasaEcologie.Domain.Models;

public class StockMovementRow
{
    public DateTime Date { get; set; }
    public string Description { get; set; } = null!;
    public float Entrees { get; set; }
    public float Sorties { get; set; }
    public float Solde { get; set; }
}
