using CurrencyChange.Api.Context;
using CurrencyChange.Api.Entities;
using CurrencyChange.Api.Repositories.Concrete;

namespace CurrencyChange.Api.Repositories.Interfaces
{
    public class ExchangeRateResponseRepository : GenericRepository<ExchangeRateResponse>, IExchangeRateResponseRepository
    {
        public ExchangeRateResponseRepository(AppDbContext context) : base(context) { }
    }
}