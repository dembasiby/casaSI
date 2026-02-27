namespace CasaEcologie.Domain.Entities;

public class AgeFournisseursServicesFourniture
{
    public int CodeFournisseurServiceFourniture { get; set; }
    public string NomFournisseurServiceFourniture { get; set; } = null!;
    public string Localite { get; set; } = null!;
    public decimal SoldeDette { get; set; }

    public List<EveAcquisitionServicesFourniture> EveAcquisitionServicesFournitures { get; set; } = [];
    public List<EveDecaissement> EveDecaissements { get; set; } = [];
}
