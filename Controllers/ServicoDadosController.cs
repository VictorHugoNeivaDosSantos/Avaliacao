using AvaliaçãoTecnobyte.Models;
using AvaliaçãoTecnobyte.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Controllers
{
    [Route("Tecnobyte")]
    [ApiController]
    public class ServicoDadosController : ControllerBase
    {
        private readonly IServiceDistrictUf _service;

        public ServicoDadosController(IServiceDistrictUf service)
        {
            _service = service;
        }

        [HttpGet("BuscarDistritoPorUf/{uf}")]
        public Task<List<DistrictUF>> GetDistrictUF([FromRoute] string uf)
        {
           return _service.GetDistrictUF(_service.ReturnCodeByUf(uf));
        }
    }
}
