using AutoMapper;
using TMS.Data.Contracts;
using TMS.Data.EntityModels;
using TMS.Domain.DomainModels;

namespace TMS.Data
{
    public class TaxRepository : ITaxRepository
    {
        private TMSContext _context;
        private IMapper _mapper;

        public TaxRepository(TMSContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TaxDomainModel>> GetTaxDetails(string municipality, DateTime date)
        {
            try
            {
                var taxDetails = await Task.Run(() => _context.Municipalities.Where(a => a.MunicipalityName == municipality && (a.StartDate == date || a.EndDate == date || (date >= a.StartDate && date <= a.EndDate))).ToList());
                var taxDomainModel = _mapper.Map<IEnumerable<TaxDomainModel>>(taxDetails);
                return taxDomainModel;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}