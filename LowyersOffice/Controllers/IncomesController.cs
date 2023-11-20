using LowyersOffice.Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class IncomesController : ControllerBase
    {
        static List<Income> incomes;
        static IncomesController()
        {
            incomes = new List<Income>();
            incomes.Add(new Income { Code = 1, Sum = 1500, Date = new DateTime(2023, 11, 12), PaymentBy = PaymentMethod.CASH });
            incomes.Add(new Income { Code = 2, Sum = 1000, Date = new DateTime(2023, 8, 30), PaymentBy = PaymentMethod.BANKTRANSFER });
            incomes.Add(new Income { Code = 3, Sum = 2000, Date = new DateTime(2023, 10, 20), PaymentBy = PaymentMethod.BANKTRANSFER });
        }
        // GET: api/<IncomesController>
        [HttpGet]
        public IEnumerable<Income> Get()
        {
            return incomes;
        }

        // GET api/<IncomesController>/5
        [HttpGet("{id}")]
        public Income Get(int id)
        {
            return incomes.Find(i => i.Code == id);
        }

        [HttpGet("bydate/{date}")]
        public IEnumerator<Income> Get(DateTime date)
        {
            return incomes.Where(i=>i.Date.Equals(date)).GetEnumerator();
        }

        // POST api/<IncomesController>
        [HttpPost]
        public void Post([FromBody] Income value)
        {
            incomes.Add(new Income()
            { Code = incomes.Count + 1, Date = new DateTime(), PaymentBy = value.PaymentBy, Sum = value.Sum });
        }

        // PUT api/<IncomesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Income value)
        {
            var income = incomes.Find(i => i.Code == id);
            if (income != null)
            {
                income.Sum = value.Sum;
                income.Date= value.Date;
                income.PaymentBy = value.PaymentBy;
            }
        }

        // DELETE api/<IncomesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var income = incomes.Find(i => i.Code == id);
            if (income != null)
                incomes.Remove(income);
        }
    }
}
