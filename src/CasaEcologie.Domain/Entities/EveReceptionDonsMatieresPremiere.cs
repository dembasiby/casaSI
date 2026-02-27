namespace CasaEcologie.Domain.Entities;

public class EveReceptionDonsMatieresPremiere
{
    public int CodeReceptionDonMatierePremiere { get; set; }
    public int CodeMatierePremiere { get; set; }
    public int CodeEmploye { get; set; }
    public int CodeFournisseur { get; set; }
    public DateTime DateReception { get; set; }
    public double Quantite { get; set; }

    public AgeEmploye AgeEmploye { get; set; } = null!;
    public AgeFournisseursMatieresPremiere AgeFournisseursMatieresPremiere { get; set; } = null!;
    public ResStockMatieresPremiere ResStockMatieresPremiere { get; set; } = null!;
    public List<EveDecaissement> EveDecaissements { get; set; } = [];
}
