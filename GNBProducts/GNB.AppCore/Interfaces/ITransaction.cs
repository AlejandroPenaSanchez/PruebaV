using GNB.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GNB.AppCore.Interfaces
{
    public interface ITransaction : IBaseEntity
    {
        string Sku { get; }
        decimal Amount { get; }
        Currency Currency { get; }

    }
}
