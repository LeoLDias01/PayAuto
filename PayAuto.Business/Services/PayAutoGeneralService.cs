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
        public void ApiCall(ref ComboBox comboUf)
        {
            //var stateClient = RestService.For<IStateApiService>("http://www.geonames.org");
           // var state = stateClient.GetStatesAsync();
        }
        public void SimpleProcess(string link ="www.uol.com.br")
        {
            spService.Start(link);
        }

    }
}
