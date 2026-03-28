using CurrencyChange.Api.Repositories.Concrete;
using CurrencyChange.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CurrencyChange.Api.Entities;

namespace CurrencyChange.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateResponseController : ControllerBase
    {
        private readonly IExchangeRateResponseRepository _exchangeRateResponseRepository;

        public ExchangeRateResponseController(IExchangeRateResponseRepository exchangeRateResponseRepository)
        {
            _exchangeRateResponseRepository = exchangeRateResponseRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ExchangeRateResponses = await _exchangeRateResponseRepository.GetAllAsync();
            return Ok(ExchangeRateResponses);
        }
        /*
        

        [HttpGet("{id}")]

        [HttpPost]

        [HttpPut("{id}")]

        [HttpDelete("{id}")]*/
    }
}
