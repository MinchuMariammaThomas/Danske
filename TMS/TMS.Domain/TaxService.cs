using TMS.Data;
using TMS.Domain.Contracts;
using TMS.Domain.Contracts.DomainExtension;
using TMS.Domain.DomainModels;

namespace TMS.Domain
{
    public class TaxService : ITaxService
    {
       private readonly TaxRepository _taxRepository;
        
        public TaxService(TaxRepository taxRepository)
        {
            _taxRepository = taxRepository;
        }
        public async Task<TaxDomainModel> GetTaxDetails(string municipality, string date)
        {
            try
            {                
                var taxList = await Task.Run(() => _taxRepository.GetTaxDetails(municipality, Convert.ToDateTime(date)));
                var taxDetails = taxList.ToList()[0];
                taxDetails.TaxAmount = TaxDomainExtension.GetTaxAmount(taxList?.ToList());
                return taxDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}