using GNB.AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GNB.AppCore.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
