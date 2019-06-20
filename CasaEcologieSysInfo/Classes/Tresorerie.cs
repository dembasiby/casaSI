using System;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Classes
{
    class Tresorerie
    {
        private static string CalculerSoldeInitialTresorerie(DateTime debutPeriode)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var soldeInitiaux = (from c in db.ResComptesTresoreries
                                     select (decimal?)c.SoldeCompte).Sum() ?? 0m;

                var totalEncaissements = (from c in db.EveEncaissements
                                          from env in db.EveEncaissementsVentes
                                          where c.CodeEncaissement == env.CodeEncaissement
                                          where env.DateEncaissement < debutPeriode.Date
                                          select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

                var encaissementCreance = (from c in db.EveEncaissements
                                           from env in db.EveEncaissementsCreances
                                           where c.CodeEncaissement == env.CodeEncaissement
                                           where env.DateEncaissement < debutPeriode
                                           select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

                var totalAutresEn = (from enc in db.EveEncaissements
                                     from aut in db.EveEncaissementsAutres
                                     where enc.CodeEncaissement == aut.CodeEncaissement
                                     where aut.DateEncaissement < debutPeriode.Date
                                     select (decimal?)aut.MontantEncaisse).Sum() ?? 0m;

                var totalDecaissements = (from d in db.EveDecaissements
                                          where d.DateDecaissement < debutPeriode.Date
                                          select (decimal?)d.Montant).Sum() ?? 0m;

                var fondsDisponibleEnCaissesEtEnBanques = soldeInitiaux
                    + totalEncaissements + totalAutresEn + encaissementCreance
                    - totalDecaissements;

                return fondsDisponibleEnCaissesEtEnBanques.ToString("n0");
            }
        }

        public static void AfficherTresorerie(DataGridView grid, DateTimePicker debut, DateTimePicker fin)
        {
            grid.Rows.Add("Fonds disponible en début de période", CalculerSoldeInitialTresorerie(debut.Value.Date));
            grid.Rows.Add("");

            grid.Rows.Add("RECETTES DE TRESORERIE");
            grid.Rows.Add("Ventes en cash", 0);
            grid.Rows.Add("Remboursement des créances", 0);
            grid.Rows.Add("Prêts et autres fonds reçus", 0);
            grid.Rows.Add("TOTAL RECETTES DE TRESORERIE", 0);
            grid.Rows.Add("Total Fonds Disponibles(avant sorties de fonds)");
            grid.Rows.Add("");

            grid.Rows.Add("DEPENSES DE TRESORERIE");
            grid.Rows.Add("Achat de matières premières", 0);
            grid.Rows.Add("Achat emballages", 0);
            grid.Rows.Add("Salaires", 0);
            grid.Rows.Add("Fournitures", 0);
            grid.Rows.Add("Réparations et maintenance", 0);
            grid.Rows.Add("Téléphone et internet", 0);
            grid.Rows.Add("Electricité et eau", 0);
            grid.Rows.Add("Taxes", 0);
            grid.Rows.Add("Intérêts payés", 0);
            grid.Rows.Add("Frais bancaires", 0);
            grid.Rows.Add("Transport (autre que matière première)", 0);
            grid.Rows.Add("SOUS TOTAL", 0);
            grid.Rows.Add("Paiement des échéances de prêts (principal)", 0);
            grid.Rows.Add("Investissements de la période", 0);
            grid.Rows.Add("Retrait des propriétaires", 0);
            grid.Rows.Add("TOTAL DEPENSES DE TRESORERIE", 0);
            grid.Rows.Add("");
            grid.Rows.Add("Trésorerie Disponible en fin de période", 0);
        }
    }
}
