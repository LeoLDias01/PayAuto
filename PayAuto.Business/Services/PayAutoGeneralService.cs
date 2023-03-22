using PayAuto.Business.ExternalApi;
using PayAuto.Business.Services.PayAutoSPService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayAuto.Business.Services
{
    public PayAutoSPService spService = new PayAutoSPService();
    public  class PayAutoGeneralService
    {
        static async Task Main()
        {
            var stateClient = RestService.For<IStateApiService>("http://www.geonames.org/");
            var State = await stateClient.GetStatesAsync();
        }
        private void SimpleProcess()
        {
            spService.Start();
        }

    }
}
