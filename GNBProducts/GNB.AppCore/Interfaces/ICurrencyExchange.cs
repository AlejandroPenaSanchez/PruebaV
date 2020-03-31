using GNB.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GNB.AppCore.Interfaces
{
    public interface ICurrencyExchange : IBaseEntity
    {
        Currency FromCurrency { get; }
        Currency ToCurrency { get; }

        decimal Rate { get; }
    }
}
