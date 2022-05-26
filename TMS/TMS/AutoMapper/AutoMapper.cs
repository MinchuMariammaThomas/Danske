using AutoMapper;
using TMS.Data.EntityModels;
using TMS.Domain.DomainModels;
using TMS.Models;

namespace TMS.AutoMapper
{
     class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Municipality, TaxDomainModel>();
            CreateMap<TaxDomainModel, TaxVM>();
        }
    }
}
