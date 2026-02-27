using CasaEcologie.Domain.Interfaces;

namespace CasaEcologie.Services;

public class ValidationService : IValidationService
{
    public (bool IsValid, string ErrorMessage) VerifierChampsMontant(string montant)
    {
        if (string.IsNullOrEmpty(montant))
            return (false, "Ce champ doit être renseigné.");

        if (!float.TryParse(montant, out _))
            return (false, "Ce champ doit contenir uniquement des chiffres.");

        return (true, string.Empty);
    }

    public (bool IsValid, string ErrorMessage) VerifierChampsQuantite(string quantite)
    {
        var result = VerifierChampsMontant(quantite);
        if (!result.IsValid)
            return result;

        if (float.Parse(quantite) <= 0)
            return (false, "La quantité doit être supérieure à zéro.");

        return (true, string.Empty);
    }

    public (bool IsValid, string ErrorMessage) VerifierChampsNonVide(string valeur, string nomChamp)
    {
        if (string.IsNullOrEmpty(valeur))
            return (false, $"Le champ {nomChamp} doit être renseigné.");

        return (true, string.Empty);
    }

    public (bool IsValid, string ErrorMessage) VerifierSelectionComboBox(int selectedIndex, string nomChamp)
    {
        if (selectedIndex < 0)
            return (false, $"Veuillez sélectionner une valeur pour {nomChamp}.");

        return (true, string.Empty);
    }
}
