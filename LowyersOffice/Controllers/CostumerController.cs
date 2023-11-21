using LowyersOffice.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        static int id = 1;
        static List<Costumer> costumers;
        static CostumerController()
        {
            costumers = new List<Costumer>();
            costumers.Add(new Costumer(){Id=id++, FirstName="Brachi",    LastName="Goldberg", Address="birinboim",      PhoneNumber="0583276404", Email="brachig404@gmail.com",  Whatsapp="0552783660"});
            costumers.Add(new Costumer(){Id=id++, FirstName="Elchanan" , LastName="Catz",     Address="Yeoshoa",        PhoneNumber="0527620838", Email="ec1234@gmail.com",      Whatsapp="0583184640"});
            costumers.Add(new Costumer(){Id=id++, FirstName="Moshe",     LastName="Mintch",   Address="Cahaneman",      PhoneNumber="03-6776402", Email="moshe100200@gmail.com", Whatsapp="0526777214"});
            costumers.Add(new Costumer(){Id=id++, FirstName="Avital",    LastName="Grinblat", Address="DameskeEliezer", PhoneNumber="0533148998", Email="grina@gmail.com",       Whatsapp="0544685330"});
            costumers.Add(new Costumer(){Id=id++, FirstName="Israsel",   LastName="Cohen",    Address="pardo",          PhoneNumber="0556488412", Email="i1c2@gmail.com",        Whatsapp="0556488412"});
            costumers.Add(new Costumer(){Id=id++, FirstName = "Zipora", LastName = "Levi", Address = "BenGurion", PhoneNumber = "03-6545512", Email = "zipi@gmail.com", Whatsapp = "03-6545512" });
        }
        // GET: api/<CostumerController>
        [HttpGet]
        public IEnumerable<Costumer> Get()
        {
            return costumers;
        }

        // GET api/<CostumerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var c= costumers.Find(c => c.Id == id);
            if (c==null)
                return NotFound();
            return Ok(c);
        }

        

        // POST api/<CostumerController>
        [HttpPost]
        public void Post([FromBody] Costumer value)
        {
            costumers.Add(new Costumer()
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
            Costumer temp = costumers.Find(c => c.Id == id);
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
