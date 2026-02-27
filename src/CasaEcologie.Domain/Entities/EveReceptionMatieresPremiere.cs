namespace CasaEcologie.Domain.Entities;

public class EveReceptionMatieresPremiere
{
    public int CodeReceptionMatierePremiere { get; set; }
    public int CodeMatierePremiere { get; set; }
    public DateTime DateReception { get; set; }
    public float Quantite { get; set; }
    public decimal Montant { get; set; }
    public int CodeFournisseurMatierePremiere { get; set; }
    public int CodeEmploye { get; set; }
    public decimal TransportMatierePremiere { get; set; }

    public AgeEmploye AgeEmploye { get; set; } = null!;
    public AgeFournisseursMatieresPremiere AgeFournisseursMatieresPremiere { get; set; } = null!;
    public ResStockMatieresPremiere ResStockMatieresPremiere { get; set; } = null!;
    public List<EveDecaissement> EveDecaissements { get; set; } = [];
}
