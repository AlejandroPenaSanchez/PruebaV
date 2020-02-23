using GNB.AppCore.Entities;
using GNB.AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GNB.AppCore.Services
{
    public class CurrencyExchangeService : ICurrencyExchangeService
    {
        private readonly IRepository<CurrencyExchange> _CurrencyExchangeRepository;

        public CurrencyExchangeService(IRepository<CurrencyExchange> currencyExchangeRepository) 
        {
            _CurrencyExchangeRepository = currencyExchangeRepository;
        }

        public CurrencyExchange GetExchange(Currency fromCurrency, Currency toCurrency)
        {
            List<CurrencyExchange> currencyExchange = _CurrencyExchangeRepository.GetAll().Where(currencyExchange => currencyExchange.FromCurrency == fromCurrency 
                                                                                                                        && currencyExchange.ToCurrency == toCurrency).ToList();

            if (currencyExchange.Any())
                return currencyExchange.First();


            return new CurrencyExchange(); 
        }


        private void shortestPath() 
        {
        
        }

    }
}
