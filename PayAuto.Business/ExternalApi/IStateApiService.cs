using PayAuto.Domain.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PayAuto.Business.ExternalApi
{
    public interface IStateApiService
    {
        [Get("/ws/{cep}/json")]
        Task<StatesResponse> GetStatesAsync(string cep);
    }
}
