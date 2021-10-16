using AvaliaçãoTecnobyte.Models;
using AvaliaçãoTecnobyte.Repositories.Interfaces;
using AvaliaçãoTecnobyte.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Services
{
    public class ServicePeople : IServicePeople
    {
        private readonly IRepositoryPeople _repository;

        public ServicePeople(IRepositoryPeople repository)
        {
            _repository = repository;
        }

        public async Task<long> AddPeopleAsync(People people)
        {
            //Validação CPF/CNPJ
            if (people.CpfCnpj.Length == 11)
                people.TypePeople = Enums.TypePeople.Fisico;

            else if (people.CpfCnpj.Length == 14)
                people.TypePeople = Enums.TypePeople.Juridico;
            else
                throw new Exception("CPF/CNPJ inválido");
            //Validação DataRegister
            if (people.DateRegister == null)
                people.DateRegister = DateTime.Today;

            else if (people.DateRegister < DateTime.Today)
                throw new Exception("Data informada maior que a data atual");

            //Validação Situation
            if (people.Situation == null)
                people.Situation = true;

            await _repository.AddPeopleAsync(people);
            return people.PeopleId;
        }

        public async Task<String> DeletarPeopleAsync(long id)
        {
            var people = await _repository.GetPessoaByIdAsync(id);
            // Esta verificação garante que a pessoa só será excluída quando a situação for false.
            if (people.Situation != true)
            {
                await _repository.DeletePeopleAsync(people);
                return "Pessoa deletada";
            }

            throw new Exception("Esta pessoa está como ativa na aplicação.");
        }

        public async Task<People> GetPeopleAsync(long id)
        {
            return await _repository.GetPessoaByIdAsync(id) ?? throw new Exception("Pessoa não encontrada");
        }
        public async Task<List<People>> GetListPeopleAsync()
        {
            return await _repository.GetListPeopleAsync();
        }
    }
}
