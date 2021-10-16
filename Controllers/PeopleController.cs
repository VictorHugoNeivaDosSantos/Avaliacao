using AvaliaçãoTecnobyte.Models;
using AvaliaçãoTecnobyte.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Controllers
{
    [ApiController]
    [Route("Tecnobyte")]
    public class PeopleController : ControllerBase
    {
        private readonly IServicePeople _service;

        public PeopleController(IServicePeople service)
        {
            _service = service;
        }

        [HttpGet("BuscarPessoa/{id}")]
        public async Task<People> GetPeopleAsync([FromRoute] long id)
        {
            return await _service.GetPeopleAsync(id);
        }

        [HttpGet("ListaPessoa")]
        public async Task<List<People>> GetListPeopleAsync([FromRoute] long id)
        {
            return  await _service.GetListPeopleAsync();
        }

        [HttpPost]
        public async Task<long> AddPeopleAsync([FromBody] People people)
        {
            return await _service.AddPeopleAsync(people);
        }

        [HttpDelete("{id}")]
        public async Task<string> DeletarPeople([FromRoute] long id)
        {
            return await _service.DeletarPeopleAsync(id);
        }
    }
}
