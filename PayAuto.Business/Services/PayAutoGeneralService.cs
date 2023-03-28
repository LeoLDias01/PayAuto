
using PayAuto.Domain.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;
using System.Net.Http.Json;

namespace PayAuto.Business.Services
{
    public class PayAutoGeneralService
    {
        public PayAutoSPService spService = new PayAutoSPService();
        public AddressResponse address;

        public async Task ApiGet(string cep)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri("https://viacep.com.br");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync($"/ws/{cep}/json");
                if (response.IsSuccessStatusCode)
                {
                    address = await response.Content.ReadFromJsonAsync<AddressResponse>();
                }
            }
        }

        public void SimpleProcess(string link, string renavam, string placa)
        {
            spService.Start(link);
            spService.DataInsert(renavam, placa);
            spService.Archives();
        }
    }
}
