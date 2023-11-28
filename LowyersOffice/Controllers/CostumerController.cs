using LowyersOffice.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private readonly DataContext _data;
        public CostumerController(DataContext data)
        {
            _data = data;
        }
        static int id = 7;
      
        // GET: api/<CostumerController>
        [HttpGet]
        public IEnumerable<Costumer> Get()
        {
            return _data.Costumers;
        }

        // GET api/<CostumerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var c= _data.Costumers.Find(c => c.Id == id);
            if (c==null)
                return NotFound();
            return Ok(c);
        }

        

        // POST api/<CostumerController>
        [HttpPost]
        public void Post([FromBody] Costumer value)
        {
            _data.Costumers.Add(new Costumer()
            {
                Id = id++,
                FirstName = value.FirstName,
                LastName = value.LastName,
                Address = value.Address,
                PhoneNumber = value.PhoneNumber,
                Email = value.Email,
                Whatsapp = value.Whatsapp
            });
        }

        // PUT api/<CostumerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Costumer value)
        {
            Costumer temp = _data.Costumers.Find(c => c.Id == id);
            if (temp != null)
            {
                temp.FirstName = value.FirstName;
                temp.LastName = value.LastName;
                temp.Address = value.Address;
                temp.PhoneNumber = value.PhoneNumber;
                temp.Email = value.Email;
                temp.Whatsapp = value.Whatsapp;
                return Ok();
            }
            else
                return NotFound();
        }
    }
}
