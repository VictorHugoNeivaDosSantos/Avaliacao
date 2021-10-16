using AvaliaçãoTecnobyte.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Services
{
    public interface IServiceDistrictUf
    {
        Task<List<DistrictUF>> GetDistrictUF(long code);
        long ReturnCodeByUf(string uf);
    }
}