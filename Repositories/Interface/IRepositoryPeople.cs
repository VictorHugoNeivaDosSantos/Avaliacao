using AvaliaçãoTecnobyte.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Repositories.Interfaces

{
    public interface IRepositoryPeople
    {
        Task<People> AddPeopleAsync(People people);
        Task DeletePeopleAsync(People people);
        Task<List<People>> GetListPeopleAsync();
        Task<People> GetPessoaByIdAsync(long id);
    }
}