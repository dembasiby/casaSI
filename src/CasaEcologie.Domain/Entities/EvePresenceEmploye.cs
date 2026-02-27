namespace CasaEcologie.Domain.Entities;

public class EvePresenceEmploye
{
    public int CodePresence { get; set; }
    public int CodeEmploye { get; set; }
    public int? CodeUtilisationDesRessources { get; set; }
    public DateTime Date { get; set; }
    public int? RemunerationJournaliere { get; set; }

    public AgeEmploye AgeEmploye { get; set; } = null!;
    public EveUtilisationRessource? EveUtilisationRessource { get; set; }
}
