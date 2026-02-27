using CasaEcologie.Domain.Models;

namespace CasaEcologie.Domain.Interfaces;

public interface IBilanService
{
    BilanData GenererBilan(DateTime debut, DateTime fin);
}
