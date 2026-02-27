namespace CasaEcologie.Domain.Entities;

public class EveAcquisitionServicesFourniture
{
    public int CodeAcquisitionServiceFourniture { get; set; }
    public DateTime Date { get; set; }
    public decimal Montant { get; set; }
    public int CodeServiceFourniture { get; set; }
    public int CodeFournisseurServiceFourniture { get; set; }
    public int? CodeEmploye { get; set; }
    public decimal? TransportServiceFourniture { get; set; }
    public string? Description { get; set; }

    public AgeEmploye? AgeEmploye { get; set; }
    public AgeFournisseursServicesFourniture AgeFournisseursServicesFourniture { get; set; } = null!;
    public ResServicesFourniture ResServicesFourniture { get; set; } = null!;
    public List<EveDecaissement> EveDecaissements { get; set; } = [];
}
