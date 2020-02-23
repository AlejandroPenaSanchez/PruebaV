using GNB.AppCore.Entities;
using GNB.AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GNB.Infraestructure.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly GNBProductsContext _GNBProductsContext;


        public EfRepository(GNBProductsContext gnbProductsContext) 
        {
            _GNBProductsContext = gnbProductsContext;
        }

        public IQueryable<T> GetAll()
        {
            return _GNBProductsContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _GNBProductsContext.Set<T>().Find(id);
        }
    }
}
