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
        private readonly IRepository<ICurrencyExchange> _CurrencyExchangeRepository;

        public CurrencyExchangeService(IRepository<ICurrencyExchange> currencyExchangeRepository)
        {
            _CurrencyExchangeRepository = currencyExchangeRepository;
        }

        public ICurrencyExchange GetExchange(Currency fromCurrency, Currency toCurrency)
        {
            List<ICurrencyExchange> currencyExchange = _CurrencyExchangeRepository.GetAll().Where(currencyExchange => currencyExchange.FromCurrency == fromCurrency
                                                                                                                        && currencyExchange.ToCurrency == toCurrency).ToList();

            if (currencyExchange.Any())
                return currencyExchange.First();

            var conversions = ShortestPath();

            return CalculeRate(conversions);
        }

        //Dijkstra's Algorithm
        private int[] ShortestPath()
        {
            return null;
        }

        private CurrencyExchange CalculeRate(int[] conversions) 
        {

            return null;
        }

    }
}
