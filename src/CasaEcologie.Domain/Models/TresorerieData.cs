namespace CasaEcologie.Domain.Models;

public class TresorerieData
{
    public string FondsDisponibleEnDebutDePeriode { get; set; } = "0";

    // Recettes
    public string VentesEnCash { get; set; } = "0";
    public string RemboursementCreances { get; set; } = "0";
    public string PretsEtAutresFondsRecus { get; set; } = "0";
    public string TotalRecettesTresorerie { get; set; } = "0";
    public string TotalFondsDisponibles { get; set; } = "0";

    // Depenses
    public string AchatMatieresPremieres { get; set; } = "0";
    public string AchatEmballages { get; set; } = "0";
    public string Salaires { get; set; } = "0";
    public string ServicesExterieurs { get; set; } = "0";
    public string Fournitures { get; set; } = "0";
    public string ReparationsEtMaintenance { get; set; } = "0";
    public string Location { get; set; } = "0";
    public string TelephoneEtInternet { get; set; } = "0";
    public string ElectriciteEtEau { get; set; } = "0";
    public string Taxes { get; set; } = "0";
    public string InteretsPayes { get; set; } = "0";
    public string FraisBancaires { get; set; } = "0";
    public string AutresTransport { get; set; } = "0";
    public string SousTotalDepenses { get; set; } = "0";
    public string PaiementPrincipal { get; set; } = "0";
    public string InvestissementsDeLaPeriode { get; set; } = "0";
    public string RetraitDesProprietaires { get; set; } = "0";
    public string TotalDepensesTresorerie { get; set; } = "0";
    public string TresorerieDisponibleEnFinDePeriode { get; set; } = "0";
}
