using Microsoft.AspNetCore.Mvc;
using Office.Core.Entites;
using Office.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private readonly ICostumerService _service;
        public CostumerController(ICostumerService service)
        {
            _service = service;
        }

        // GET: api/<CostumerController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_service.Get());
        }

        // GET api/<CostumerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var c = _service.Get(id);
            if (c == null)
                return NotFound();
            return Ok(c);
        }



        // POST api/<CostumerController>
        [HttpPost]
        public void Post([FromBody] Costumer value)
        {
            _service.Post(value);
        }

        // PUT api/<CostumerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Costumer value)
        {
            var c = _service.Put(id, value);
            if (c == null)
                return NotFound();
            return Ok();
        }
    }
}
