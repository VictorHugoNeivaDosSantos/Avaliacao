using AvaliaçãoTecnobyte.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Services.Interface
{
    public interface IServicePeople
    {
        Task<long> AddPeopleAsync(People people);
        Task<string> DeletarPeopleAsync(long id);
        Task<List<People>> GetListPeopleAsync();
        Task<People> GetPeopleAsync(long id);
    }
}