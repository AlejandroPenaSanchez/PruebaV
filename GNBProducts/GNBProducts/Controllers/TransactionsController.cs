using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNB.AppCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GNBProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {

        #region Constructor and Properties
        private readonly IRepository<ITransaction> _TransactionsRepository;
        private readonly ITransactionService _TransactionService;

        public TransactionsController(IRepository<ITransaction> transactionsRepository, ITransactionService transactionService) 
        {
            _TransactionsRepository = transactionsRepository;
            _TransactionService = transactionService;
        }

        #endregion

        #region Methods
        // GET: api/Transactions
        [HttpGet]
        public IEnumerable<ITransaction> Get()
        {
            return _TransactionsRepository.GetAll().ToList();
        }

        // GET: api/Transactions/5
        [HttpGet("{id}", Name = "Get")]
        public ITransaction Get(int id)
        {
            return _TransactionsRepository.GetById(id);
        }

        // GET: api/Transactions/5
        [HttpGet("{sku}", Name = "GetEurTransactionBySku")]
        public ITransaction GetEurTransactionBySku(string sku)
        {
            return _TransactionService.GetEurTransactionBySku(sku);
        }

        // POST: api/Transactions
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Transactions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        #endregion
    }
}
