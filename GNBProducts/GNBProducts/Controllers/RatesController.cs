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
    public class RatesController : ControllerBase
    {
        private readonly IRepository<ICurrencyExchange> _CurrencyExchangeRepository;

        public RatesController(IRepository<ICurrencyExchange> transactionsRepository)
        {
            _CurrencyExchangeRepository = transactionsRepository;
        }

        [HttpGet]
        public IEnumerable<ICurrencyExchange> Get()
        {
            return _CurrencyExchangeRepository.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "Get")]
        public ICurrencyExchange Get(int id)
        {
            return _CurrencyExchangeRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}