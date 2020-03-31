using GNB.AppCore.Entities;
using GNB.Infraestructure.Data.Entities;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace GNB.Infraestructure.Data
{
    public class DataBaseInitializer
    {
        private readonly GNBProductsContext _GNBProductsContext;
        private readonly DbInitializerSettings _DbInitializerSettings;

        public DataBaseInitializer(GNBProductsContext gnbProductsContext, IOptions<DbInitializerSettings> dbInitializerSettings)
        {
            _GNBProductsContext = gnbProductsContext;
            _DbInitializerSettings = dbInitializerSettings.Value;
        }

        public void Initialize()
        {
            var rateJson = JsonSerializer.Deserialize<RateJsonData[]>(File.ReadAllText(_DbInitializerSettings.RatesJsonPath));
            var transactionJson = JsonSerializer.Deserialize<TransactionJsonData[]>(File.ReadAllText(_DbInitializerSettings.TransactionsJsonPath));
      
            AddCurrencies(rateJson.Select(rate => rate.To).Union(rateJson.Select(rate => rate.From)).ToArray());
            AddRates(rateJson);
            AddTransactions(transactionJson);
        }

        private void AddTransactions(TransactionJsonData[] transactions) 
        {
            foreach (var transaction in transactions)
            {
                _GNBProductsContext.Add(new EfTransaction()
                {
                    Sku = transaction.Sku,
                    Amount = decimal.Parse(transaction.Amount),
                    CurrencyId = _GNBProductsContext.Set<Currency>().Where<Currency>(currency => currency.Name == transaction.Currency).FirstOrDefault().Id
                });
            }

            _GNBProductsContext.SaveChanges();
        }

        private void AddRates(RateJsonData[] rates)
        {
            foreach (var rate in rates)
            {
                _GNBProductsContext.Add(new EfCurrencyExchange()
                {
                    FromCurrencyId = _GNBProductsContext.Set<Currency>().Where<Currency>(currency => currency.Name == rate.From).FirstOrDefault().Id,
                    ToCurrencyId = _GNBProductsContext.Set<Currency>().Where<Currency>(currency => currency.Name == rate.To).FirstOrDefault().Id,
                    Rate = decimal.Parse(rate.Rate)
                });
            }
            _GNBProductsContext.SaveChanges();
        }

        private void AddCurrencies(string[] currencies)
        {
            foreach(var currency in currencies) 
            {
                _GNBProductsContext.Add(new Currency() 
                {
                    Name = currency
                });
            }

            _GNBProductsContext.SaveChanges();
        }

    }
}
