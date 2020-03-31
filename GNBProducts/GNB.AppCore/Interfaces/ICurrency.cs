using System;
using System.Collections.Generic;
using System.Text;

namespace GNB.AppCore.Interfaces
{
    public interface ICurrency : IBaseEntity
    {
        public string Name { get; }
    }
}
