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
        public decimal Amount 
        {
            get 
            {
                return Amount;
            }
            set 
            {
                Amount = Math.Round(value, ApplicationConstants.NumbersRound);
            } 
        }
        public Currency Currency { get; set; }
    }
}
