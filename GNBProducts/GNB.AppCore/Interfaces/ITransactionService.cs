using System;
using System.Collections.Generic;
using System.Text;

namespace GNB.AppCore.Interfaces
{
    public interface ITransactionService
    {
        ITransaction GetEurTransactionBySku(string sku);
    }
}
