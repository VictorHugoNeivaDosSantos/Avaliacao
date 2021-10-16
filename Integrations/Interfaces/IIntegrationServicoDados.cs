using AvaliaçãoTecnobyte.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Integrations.Interfaces
{
    public interface IIntegrationServicoDados
    {
        Task<List<DistrictUF>> GetDistrictByUf(long uf);
    }
}