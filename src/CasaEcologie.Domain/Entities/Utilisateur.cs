namespace CasaEcologie.Domain.Entities;

public class Utilisateur
{
    public int CodeEmploye { get; set; }
    public string NomUtilisateur { get; set; } = null!;
    public string MotDePasse { get; set; } = null!;
    public string Role { get; set; } = null!;

    public AgeEmploye AgeEmploye { get; set; } = null!;
}
