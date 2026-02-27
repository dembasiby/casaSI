namespace CasaEcologie.Domain.Models;

public class CreanceClientData
{
    public int CodeClient { get; set; }
    public string NomClient { get; set; } = null!;
    public decimal SoldeCreance { get; set; }
}
