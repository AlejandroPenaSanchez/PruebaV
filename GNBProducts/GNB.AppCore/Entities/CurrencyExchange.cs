using GNB.AppCore.Constants;
using GNB.AppCore.Interfaces;
using System;

namespace GNB.AppCore.Entities
{
    public class CurrencyExchange : BaseEntity, ICurrencyExchange
    {
        public Currency FromCurrency { get; set; }
        public Currency ToCurrency { get; set; }

        public decimal Rate
        {
            get 
            {
                return Rate;
            }
            set 
            {
                Rate = Math.Round(value, ApplicationConstants.NumbersRound);
            }
        }
    }
}
