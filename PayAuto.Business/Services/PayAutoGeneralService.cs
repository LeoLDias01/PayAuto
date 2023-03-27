using PayAuto.Business.ExternalApi;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayAuto.Business.Services
{
    public class PayAutoGeneralService
    {
        public PayAutoSPService spService = new PayAutoSPService();
        public void ApiCall(string cep)
        {
            var stateClient = RestService.For<IStateApiService>("https://viacep.com.br");
            var state = stateClient.GetStatesAsync(cep);
        
        }
        public void SimpleProcess(string link, string renavam, string placa)
        {
            spService.Start(link);
            spService.DataInsert(renavam, placa);
            spService.Archives();
        }
    }
}
