using GNB.AppCore.Constants;
using GNB.AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GNB.AppCore.Entities
{
    public class Transaction : BaseEntity, ITransaction
    {
        public string Sku { get; set; }
        private decimal _Amount { get; set; }
        public Currency Currency { get; set; }

        //public Transaction(ICurrency currency) 
        //{
        //    Currency = currency;
        //}
        public decimal Amount 
        {
            get 
            {
                return _Amount;
            }
            set 
            {
                _Amount = Math.Round(value, ApplicationConstants.NumbersRound);
            } 
        }
    }
}
