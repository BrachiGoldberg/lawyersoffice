using LowyersOffice.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CourtCaseController : ControllerBase
    {
        private readonly DataContext _data;
        public CourtCaseController(DataContext data)
        {
            _data = data;
        }

        static int id = 5;

        // GET: api/<CourtCaseController>
        [HttpGet]
        public IEnumerable<CourtCase> Get()
        {
            return _data.CourtCases;
        }


 
        [HttpGet("date")]
        public IEnumerable<CourtCase> Get(DateTime date )
        {
            return _data.CourtCases.Where(c=>c.OpeningDate.CompareTo(date)>=0);
        }

        // GET api/<CourtCaseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var court = _data.CourtCases.Find(c => c.Code == id);
            if(court == null)
                return NotFound();
            return Ok(court);
        }


        // POST api/<CourtCaseController>
        [HttpPost]
        public void Post([FromBody] CourtCase value)
        {
            _data.CourtCases.Add(new CourtCase()
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
            var court = _data.CourtCases.Find(c => c.Code == id);
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
            var found = _data.CourtCases.Find(c => c.Code == id);
            if (found != null)
            {
                found.CourtCaseStatus = status;
                return Ok();
            }
            return NotFound();
        }
    }
}
