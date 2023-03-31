using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayAuto.Domain.Models
{
    public struct WorksheetRows
    {
        public long Renavam { get; set; }
        public string LicensePlate { get; set; }
        public string Chassi { get; set; }
        public string Uf { get; set; }
    }
}
