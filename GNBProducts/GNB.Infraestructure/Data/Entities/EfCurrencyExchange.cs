using GNB.AppCore.Entities;
using GNB.AppCore.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace GNB.Infraestructure.Data.Entities
{
    public class EfCurrencyExchange : CurrencyExchange, ICurrencyExchange
    {
        public int FromCurrencyId { get; set; }
        public int ToCurrencyId { get; set; }

        //public EfCurrencyExchange(ICurrency fromCurrency, ICurrency toCurrency) : base(fromCurrency, toCurrency)  
        //{
        //}
    }
}
