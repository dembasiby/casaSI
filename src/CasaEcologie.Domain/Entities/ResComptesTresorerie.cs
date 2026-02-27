namespace CasaEcologie.Domain.Entities;

public class ResComptesTresorerie
{
    public int CodeCompte { get; set; }
    public string NomCompte { get; set; } = null!;
    public decimal SoldeCompte { get; set; }

    public List<EveDecaissement> EveDecaissements { get; set; } = [];
    public List<EveEncaissement> EveEncaissements { get; set; } = [];
}
