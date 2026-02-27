using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CasaEcologie.Services;

public class AuthService : IAuthService
{
    private readonly CasaDbContext _db;

    public AuthService(CasaDbContext db)
    {
        _db = db;
    }

    public (bool Success, string Role, string ErrorMessage) Authentifier(string nomUtilisateur, string motDePasse)
    {
        var utilisateur = _db.Utilisateurs
            .FirstOrDefault(u => u.NomUtilisateur == nomUtilisateur);

        if (utilisateur == null)
            return (false, string.Empty, "Nom d'utilisateur incorrect.");

        if (!VerifierMotDePasse(motDePasse, utilisateur.MotDePasse))
            return (false, string.Empty, "Mot de passe incorrect.");

        return (true, utilisateur.Role, string.Empty);
    }

    public string HasherMotDePasse(string motDePasse)
    {
        return BCrypt.Net.BCrypt.HashPassword(motDePasse, BCrypt.Net.BCrypt.GenerateSalt(12));
    }

    public bool VerifierMotDePasse(string motDePasse, string hash)
    {
        return BCrypt.Net.BCrypt.Verify(motDePasse, hash);
    }
}
