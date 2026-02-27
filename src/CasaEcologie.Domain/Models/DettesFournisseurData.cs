namespace CasaEcologie.Domain.Models;

public class DettesFournisseurData
{
    public int CodeFournisseur { get; set; }
    public string NomFournisseur { get; set; } = null!;
    public string TypeFournisseur { get; set; } = null!;
    public decimal SoldeDette { get; set; }
}
