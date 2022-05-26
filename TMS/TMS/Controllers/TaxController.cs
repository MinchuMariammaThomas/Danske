using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;
using TMS.Domain.Contracts;
using TMS.Models;

namespace TMS.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        ITaxService _taxService;
        IMapper _mapper;
        public TaxController(ITaxService taxService, IMapper mapper)
        {
            _taxService = taxService;
            _mapper = mapper;
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetTax")]        
        public async Task<IActionResult> GetTax(string municipality, string date)
        {
            TaxVM tax = new TaxVM();
            if (String.IsNullOrEmpty(municipality) || String.IsNullOrEmpty(date))
            {
                return BadRequest();
            }
            var taxDomain = await _taxService.GetTaxDetails(municipality, date);
            var taxDetails = _mapper.Map<TaxVM>(taxDomain);
            
            return CreatedAtAction("Tax Calculated", taxDetails);
        }
    }
}
