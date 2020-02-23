using GNB.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GNB.AppCore.Interfaces
{
    public interface ICurrencyExchange : IBaseEntity
    {
        Currency FromCurrency { get; set; }
        Currency ToCurrency { get; set; }

        decimal Rate { get; set; }
    }
}
