using TMS.Domain.DomainModels;

namespace TMS.Domain.Contracts
{
    public interface ITaxService
    {
       async Task<TaxDomainModel> GetTaxDetails(string municipality, string date);
    }
}