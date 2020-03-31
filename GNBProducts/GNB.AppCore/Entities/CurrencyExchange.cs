using GNB.AppCore.Constants;
using GNB.AppCore.Interfaces;
using System;

namespace GNB.AppCore.Entities
{
    public class CurrencyExchange : BaseEntity, ICurrencyExchange
    {
        public Currency FromCurrency { get; set; }
        public Currency ToCurrency { get; set; }

        private decimal _Rate { get; set; }

        //public CurrencyExchange(ICurrency fromCurrency, ICurrency toCurrency) 
        //{
        //    FromCurrency = fromCurrency;
        //    ToCurrency = toCurrency;
        //}

        public decimal Rate
        {
            get 
            {
                return _Rate;
            }
            set 
            {
                _Rate = Math.Round(value, ApplicationConstants.NumbersRound);
            }
        }
    }
}
