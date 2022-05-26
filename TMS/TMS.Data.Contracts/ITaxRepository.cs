using TMS.Data.EntityModels;
using TMS.Domain.DomainModels;

namespace TMS.Data.Contracts
{
    public interface ITaxRepository
    {
        Task<IEnumerable<TaxDomainModel>> GetTaxDetails(string municipality, DateTime date);
    }
}