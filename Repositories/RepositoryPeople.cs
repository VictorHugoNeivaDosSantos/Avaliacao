using AvaliaçãoTecnobyte.Context;
using AvaliaçãoTecnobyte.Models;
using AvaliaçãoTecnobyte.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Repositories
{
    public class RepositoryPeople : IRepositoryPeople
    {
        private readonly ContextSystem _context;

        public RepositoryPeople(ContextSystem context)
        {
            _context = context;
        }

        public async Task<People> AddPeopleAsync(People people)
        {
            await _context.People.AddAsync(people);
            await _context.SaveChangesAsync();
            return people;
        }

        public async Task<People> GetPessoaByIdAsync(long id)
        {
            return await _context.People.FirstOrDefaultAsync(f => f.PeopleId == id);
        }

        public async Task DeletePeopleAsync(People people)
        {
            _context.People.Remove(people);
            await _context.SaveChangesAsync();
        }

        public async Task<List<People>> GetListPeopleAsync()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<List<People>> GetListPeopleAsync(string name)
        {
            
            var people = new List<People>();
            return people;
        }
    }
}
