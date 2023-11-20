using LowyersOffice.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CourtCaseController : ControllerBase
    {

        static List<CourtCase> courtes;
        static CourtCaseController()
        {
            courtes = new List<CourtCase>();
            courtes.Add(new CourtCase()
            {
                Code = 1,
                CourtType = CourtCaseType.TAXES,
                Fees = 5000,
                OpeningDate = new DateTime(2023, 11, 20),
                CourtCaseStatus = CourtStatus.ACTIVE,
                CostumerStatusOnCourt = CostumerStatus.PROSECUTOR,
                AmountToPay = 5000
            });
            courtes.Add(new CourtCase()
            {
                Code = 2,
                CourtType = CourtCaseType.REALESTATE,
                Fees = 3000,
                OpeningDate = new DateTime(2023, 11, 17),
                CourtCaseStatus = CourtStatus.ACTIVE,
                CostumerStatusOnCourt = CostumerStatus.PROSECUTOR,
                AmountToPay = 3000
            });
            courtes.Add(new CourtCase()
            {
                Code = 3,
                CourtType = CourtCaseType.TAXES,
                Fees = 6000,
                OpeningDate = new DateTime(2023, 10, 17),
                CourtCaseStatus = CourtStatus.ACTIVE,
                CostumerStatusOnCourt = CostumerStatus.DEFENDANT,
                AmountToPay = 4500
            });
            courtes.Add(new CourtCase()
            {
                Code = 4,
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
            return courtes.ToList();
        }

        // GET api/<CourtCaseController>/5
        [HttpGet("{id}")]
        public CourtCase Get(int id)
        {
            return courtes.Find(c => c.Code == id);
        }

        [HttpGet("courttype/{type}")]
        public IEnumerable<CourtCase> Get(CourtCaseType type)
        {
            return courtes.Where(c => c.CourtType == type);
        }

        // POST api/<CourtCaseController>
        [HttpPost]
        public void Post([FromBody] CourtCase value)
        {
            courtes.Add(new CourtCase()
            {
                Code = courtes.Count + 1,
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
        public void Put(int id, [FromBody] CourtCase value)
        {
            var court = courtes.Find(c => c.Code == id);
            if (court != null)
            {
                court.CourtType = value.CourtType;
                court.Fees = value.Fees;
                court.CourtCaseStatus = value.CourtCaseStatus;
                court.CostumerStatusOnCourt = value.CostumerStatusOnCourt;
                court.AmountToPay = value.Fees;
            }
        }


        [HttpPut("{id}/status")]
        public void Put(int id, [FromBody] CourtStatus status)
        {
            var found = courtes.Find(c => c.Code == id);
            if (found != null)
                found.CourtCaseStatus = status;
        }
    }
}
