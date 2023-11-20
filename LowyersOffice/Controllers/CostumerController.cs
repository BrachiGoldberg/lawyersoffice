using LowyersOffice.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        static List<Costumer> costumers;
        static CostumerController()
        {
            costumers = new List<Costumer>();
            costumers.Add(new Costumer(1, "Brachi", "Goldberg", "birinboim", "0583276404", "brachig404@gmail.com", "0552783660"));
            costumers.Add(new Costumer(2, "Elchanan", "Catz", "Yeoshoa", "0527620838", "ec1234@gmail.com", "0583184640"));
            costumers.Add(new Costumer(3, "Moshe", "Mintch", "Cahaneman", "03-6776402", "moshe100200@gmail.com", "0526777214"));
            costumers.Add(new Costumer(4, "Avital", "Grinblat", "DameskeEliezer", "0533148998", "grina@gmail.com", "0544685330"));
            costumers.Add(new Costumer(5, "Israsel", "Cohen", "pardo", "0556488412", "i1c2@gmail.com", "0556488412"));
            costumers.Add(new Costumer(6, "Zipora", "Levi", "BenGurion", "03-6545512", "zipi@gmail.com", "03-6545512"));
        }
        // GET: api/<CostumerController>
        [HttpGet]
        public IEnumerable<Costumer> Get()
        {
            return costumers;
        }

        // GET api/<CostumerController>/5
        [HttpGet("{id}")]
        public Costumer Get(int id)
        {
            return costumers.Find(c => c.Id == id);
        }

        [HttpGet("byname/{lastName}")]
        public IEnumerable<Costumer> Get(string lastName)
        {
            return costumers.Where(c => c.LastName == lastName);
        }

        // POST api/<CostumerController>
        [HttpPost]
        public void Post([FromBody] Costumer value)
        {
            costumers.Add(new Costumer(costumers.Count+1, value.FirstName, value.LastName, value.Address,
                value.PhoneNumber, value.Email, value.Whatsapp));
        }

        // PUT api/<CostumerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Costumer value)
        {
            Costumer temp = costumers.Find(c => c.Id == id);
            if (temp != null)
            {
                temp.FirstName = value.FirstName;
                temp.LastName = value.LastName;
                temp.Address = value.Address;
                temp.PhoneNumber = value.PhoneNumber;
                temp.Email = value.Email;
                temp.Whatsapp = value.Whatsapp;
            }

        }
    }
}
