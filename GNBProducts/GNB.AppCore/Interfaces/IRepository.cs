using GNB.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GNB.AppCore.Interfaces
{
    public interface IRepository<out T> where T : IBaseEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
