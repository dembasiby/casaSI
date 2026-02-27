namespace CasaEcologie.Domain.Entities;

public class ResServicesFourniture
{
    public int CodeServiceFourniture { get; set; }
    public string NomServiceFourniture { get; set; } = null!;

    public List<EveAcquisitionServicesFourniture> EveAcquisitionServicesFournitures { get; set; } = [];
}
