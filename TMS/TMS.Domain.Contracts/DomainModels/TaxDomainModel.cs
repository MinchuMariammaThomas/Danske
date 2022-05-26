using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.DomainModels
{
    public class TaxDomainModel
    {
        public string MunicipalityName { get; set; }
        public int TaxType { get; set; }
        public double TaxAmount { get; set; }
        public string Date { get; set; }
    }
}
