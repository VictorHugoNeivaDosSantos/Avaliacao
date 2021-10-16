using AvaliaçãoTecnobyte.Integrations.Interfaces;
using AvaliaçãoTecnobyte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Services
{
    public class ServiceDistrictUf : IServiceDistrictUf
    {
        private readonly IIntegrationServicoDados _service;

        public ServiceDistrictUf(IIntegrationServicoDados service)
        {
            _service = service;
        }

        public async Task<List<DistrictUF>> GetDistrictUF(long code)
        {
            return await _service.GetDistrictByUf(code);
        }

        public long ReturnCodeByUf(string uf)
        {
            if (uf == "RO")
                return 11;
            if (uf == "AC")
                return 12;
            if (uf == "AM")
                return 13;
            if (uf == "RR")
                return 14;
            if (uf == "PA")
                return 15;
            if (uf == "AP")
                return 16;
            if (uf == "TO")
                return 17;
            if (uf == "MA")
                return 21;
            if (uf == "PI")
                return 22;
            if (uf == "CE")
                return 23;
            if (uf == "RN")
                return 24;
            if (uf == "PB")
                return 25;
            if (uf == "PE")
                return 26;
            if (uf == "AL")
                return 27;
            if (uf == "SE")
                return 28;
            if (uf == "BA")
                return 29;
            if (uf == "MG")
                return 31;
            if (uf == "ES")
                return 32;
            if (uf == "RJ")
                return 33;
            if (uf == "SP")
                return 35;
            if (uf == "PR")
                return 41;
            if (uf == "SC")
                return 42;
            if (uf == "RS")
                return 43;
            if (uf == "MS")
                return 50;
            if (uf == "MT")
                return 51;
            if (uf == "GO")
                return 52;
            if (uf == "DF")
                return 53;

            throw new Exception("UF não encontrada.");
        }
    }
}
