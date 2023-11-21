using LowyersOffice.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CourtCaseController : ControllerBase
    {
        static int id = 1;
        static List<CourtCase> courtes;
        static CourtCaseController()
        {
            courtes = new List<CourtCase>();
            courtes.Add(new CourtCase()
            {
                Code = id++,
                CourtType = CourtCaseType.TAXES,
                Fees = 5000,
                OpeningDate = new DateTime(2023, 11, 20),
                CourtCaseStatus = CourtStatus.ACTIVE,
                CostumerStatusOnCourt = CostumerStatus.PROSECUTOR,
                AmountToPay = 5000
            });
            courtes.Add(new CourtCase()
            {
                Code = id++,
                CourtType = CourtCaseType.REALESTATE,
                Fees = 3000,
                OpeningDate = new DateTime(2023, 11, 17),
                CourtCaseStatus = CourtStatus.ACTIVE,
                CostumerStatusOnCourt = CostumerStatus.PROSECUTOR,
                AmountToPay = 3000
            });
            courtes.Add(new CourtCase()
            {
                Code = id++,
                CourtType = CourtCaseType.TAXES,
                Fees = 6000,
                OpeningDate = new DateTime(2023, 10, 17),
                CourtCaseStatus = CourtStatus.ACTIVE,
                CostumerStatusOnCourt = CostumerStatus.DEFENDANT,
                AmountToPay = 4500
            });
            courtes.Add(new CourtCase()
            {
                Code = id++,
                CourtType = CourtCaseType.ADMINISTRATIVELAW,
                Fees = 8000,
                OpeningDate = new DateTime(2023, 8, 30),
                CourtCaseStatus = CourtStatus.ACTIVE,
                CostumerStatusOnCourt = CostumerStatus.PROSECUTOR,
                AmountToPay = 5000
            });
        }

        // GET: api/<CourtCaseController>
        [HttpGet]
        public IEnumerable<CourtCase> Get()
        {
            return courtes;
        }


 
        [HttpGet("date")]
        public IEnumerable<CourtCase> Get(DateTime date )
        {
            return courtes.Where(c=>c.OpeningDate.CompareTo(date)>=0);
        }

        // GET api/<CourtCaseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var court = courtes.Find(c => c.Code == id);
            if(court == null)
                return NotFound();
            return Ok(court);
        }


        // POST api/<CourtCaseController>
        [HttpPost]
        public void Post([FromBody] CourtCase value)
        {
            courtes.Add(new CourtCase()
            {
                Code = id++,
                CourtType = value.CourtType,
                Fees = value.Fees,
                OpeningDate = new DateTime(),
                CourtCaseStatus = value.CourtCaseStatus,
                CostumerStatusOnCourt = value.CostumerStatusOnCourt,
                AmountToPay = value.Fees
            });
        }

        // PUT api/<CourtCaseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CourtCase value)
        {
            var court = courtes.Find(c => c.Code == id);
            if (court != null)
            {
                court.CourtType = value.CourtType;
                court.Fees = value.Fees;
                court.CourtCaseStatus = value.CourtCaseStatus;
                court.CostumerStatusOnCourt = value.CostumerStatusOnCourt;
                court.AmountToPay = value.AmountToPay;
                return Ok();
            }
            return NotFound();
        }


        [HttpPut("{id}/status")]
        public ActionResult Put(int id, [FromBody] CourtStatus status)
        {
            var found = courtes.Find(c => c.Code == id);
            if (found != null)
            {
                found.CourtCaseStatus = status;
                return Ok();
            }
            return NotFound();
        }
    }
}
