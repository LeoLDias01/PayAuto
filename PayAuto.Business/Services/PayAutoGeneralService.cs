using PayAuto.Business.ExternalApi;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayAuto.Business.Services
{
    public  class PayAutoGeneralService
    {
        public PayAutoSPService spService = new PayAutoSPService();
        static async Task Main()
        {
            var stateClient = RestService.For<IStateApiService>("http://www.geonames.org/");
            var State = await stateClient.GetStatesAsync();
        }
        private void SimpleProcess(string link ="www.uol.com.br")
        {
            spService.Start(link);
        }

    }
}
