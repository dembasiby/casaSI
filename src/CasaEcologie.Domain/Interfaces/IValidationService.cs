namespace CasaEcologie.Domain.Interfaces;

public interface IValidationService
{
    (bool IsValid, string ErrorMessage) VerifierChampsMontant(string montant);
    (bool IsValid, string ErrorMessage) VerifierChampsQuantite(string quantite);
    (bool IsValid, string ErrorMessage) VerifierChampsNonVide(string valeur, string nomChamp);
    (bool IsValid, string ErrorMessage) VerifierSelectionComboBox(int selectedIndex, string nomChamp);
}
