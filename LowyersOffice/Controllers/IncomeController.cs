using LowyersOffice.Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly DataContext _data;
        public IncomeController(DataContext data)
        {
            _data = data;
        }

        static int id = 4;
        // GET: api/<IncomesController>
        [HttpGet]
        public IEnumerable<Income> Get()
        {
            return _data.Incomes;
        }
        
        // GET api/<IncomesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var income= _data.Incomes.Find(i => i.Code == id);
            if (income == null)
                return NotFound();
            return Ok(income);
        }


        // POST api/<IncomesController>
        [HttpPost]
        public void Post([FromBody] Income value)
        {
            _data.Incomes.Add(new Income()
            { Code = id++, Date = new DateTime(), PaymentBy = value.PaymentBy, Sum = value.Sum });
        }

        // PUT api/<IncomesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Income value)
        {
            var income = _data.Incomes.Find(i => i.Code == id);
            if (income != null)
            {
                income.Sum = value.Sum;
                income.Date= value.Date;
                income.PaymentBy = value.PaymentBy;
                return Ok();
            }
            return NotFound();
        }


        [HttpPut("{id}/sum")]
        public ActionResult Put(int id, int sum)
        {
            var income = _data.Incomes.Find(i => i.Code == id);
            if (income != null)
            {
                income.Sum = sum;
                return Ok();
            }
            return NotFound();
        }


        // DELETE api/<IncomesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var income = _data.Incomes.Find(i => i.Code == id);
            if (income != null)
                _data.Incomes.Remove(income);
        }
    }
}
