namespace CasaEcologie.Domain.Entities;

public class AgeFournisseursMatieresPremiere
{
    public int CodeFournisseurMatierePremiere { get; set; }
    public string Nom { get; set; } = null!;
    public string Localite { get; set; } = null!;
    public decimal SoldeDette { get; set; }

    public List<EveDecaissement> EveDecaissements { get; set; } = [];
    public List<EveReceptionMatieresPremiere> EveReceptionMatieresPremieres { get; set; } = [];
    public List<EveReceptionDonsMatieresPremiere> EveReceptionDonsMatieresPremieres { get; set; } = [];
}
