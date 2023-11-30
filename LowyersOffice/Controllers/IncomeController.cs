using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Office.Core.Entites;
using Office.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _service;
        public IncomeController(IIncomeService service)
        {
            _service = service;
        }

        static int id = 4;
        // GET: api/<IncomesController>
        [HttpGet]
        public IEnumerable<Income> Get()
        {
            return _service.Get();
        }
        
        // GET api/<IncomesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var income = _service.Get(id);
            if (income == null)
                return NotFound();
            return Ok(income);
        }


        // POST api/<IncomesController>
        [HttpPost]
        public void Post([FromBody] Income value)
        {
            _service.Post(value);
        }

        // PUT api/<IncomesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Income value)
        {
            var income = _service.Put(id, value);
            if (income != null)
                return Ok();
            return NotFound();
        }


        [HttpPut("{id}/sum")]
        public ActionResult Put(int id, int sum)
        {
            var income = _service.Put(id, sum);
            if (income != null)
                return Ok();
            return NotFound();
        }


        // DELETE api/<IncomesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var income = _service.Delete(id);
            if (income != null)
                return Ok();
            return NotFound();
        }
    }
}
