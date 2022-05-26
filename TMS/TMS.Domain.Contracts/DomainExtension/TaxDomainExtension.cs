using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Domain.DomainModels;

namespace TMS.Domain.Contracts.DomainExtension
{
    public static class TaxDomainExtension
    {
        public static double GetTaxAmount(IList<TaxDomainModel> taxDetails)
        {
            var tax = (() =>
            {
                switch (taxDetails[0].TaxType)
                {
                    case 1:
                        ApplyTaxRuleOne(taxDetails);
                        break;
                    case 2:
                        ApplyTaxRuleTwo(taxDetails);
                        break;
                    default:
                        break;
                }
            });
            return Convert.ToDouble(tax);
        }

        private static double ApplyTaxRuleOne(IList<TaxDomainModel> taxDetails)
        {
            return taxDetails.Sum(item => item.TaxAmount);
        }
        private static double ApplyTaxRuleTwo(IList<TaxDomainModel> taxDetails)
        {            
            return taxDetails.Min(a => a.TaxAmount);
        }
    }
}
