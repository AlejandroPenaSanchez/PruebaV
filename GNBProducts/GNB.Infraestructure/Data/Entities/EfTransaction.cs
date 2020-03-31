using GNB.AppCore.Entities;
using GNB.AppCore.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace GNB.Infraestructure.Data.Entities
{
    public class EfTransaction : Transaction, ITransaction
    {
        public int CurrencyId { get; set; }

        //public EfTransaction(ICurrency currency) : base (currency) 
        //{ 
        //}
    }
}
