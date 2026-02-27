using CasaEcologie.Domain.Models;

namespace CasaEcologie.Domain.Interfaces;

public interface ICompteDeResultatService
{
    CompteDeResultatData GenererCompteDeResultat(DateTime debut, DateTime fin);
}
