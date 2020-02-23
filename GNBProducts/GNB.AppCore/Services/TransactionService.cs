using GNB.AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace GNB.AppCore.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IRepository<ITransaction> _TransactionRepository;

        public TransactionService(IRepository<ITransaction> transactionRepository) 
        {
            _TransactionRepository = transactionRepository;
        }

        public ITransaction GetEurTransactionBySku(string sku)
        {
            throw new NotImplementedException();
        }
    }
}
