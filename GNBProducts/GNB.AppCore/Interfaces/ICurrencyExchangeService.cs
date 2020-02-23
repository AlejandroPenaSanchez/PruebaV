using GNB.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GNB.AppCore.Interfaces
{
    public interface ICurrencyExchangeService
    {
        public CurrencyExchange GetExchange(Currency from, Currency to);
    }
}
