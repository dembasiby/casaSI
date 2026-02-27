namespace CasaEcologie.Domain.Interfaces;

public interface IAuthService
{
    (bool Success, string Role, string ErrorMessage) Authentifier(string nomUtilisateur, string motDePasse);
    string HasherMotDePasse(string motDePasse);
    bool VerifierMotDePasse(string motDePasse, string hash);
}
