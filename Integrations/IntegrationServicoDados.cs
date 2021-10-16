using AvaliaçãoTecnobyte.Integrations.Interfaces;
using AvaliaçãoTecnobyte.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Integrations
{
    public class IntegrationServicoDados : IIntegrationServicoDados
    {

        public async Task<List<DistrictUF>> GetDistrictByUf(long uf)
        {

            using (var client = new HttpClient())
            {
                string uri = $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/distritos";

                string request = await client.GetStringAsync(uri);

                var response = JsonConvert.DeserializeObject<List<DistrictUF>>(request);
                return response;
            }

        }
    }
}
