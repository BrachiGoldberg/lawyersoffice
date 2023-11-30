using Microsoft.AspNetCore.Mvc;
using Office.Core.Entites;
using Office.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LowyersOffice.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CourtCaseController : ControllerBase
    {
        private readonly ICourtCaseService _service;
        public CourtCaseController(ICourtCaseService service)
        {
            _service = service;
        }

        // GET: api/<CourtCaseController>
        [HttpGet]
        public IEnumerable<CourtCase> Get()
        {
            return _service.Get();
        }


 
        [HttpGet("date")]
        public IEnumerable<CourtCase> Get(DateTime date )
        {
            return _service.Get(date);
        }

        // GET api/<CourtCaseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var court = _service.Get(id);
            if(court == null)
                return NotFound();
            return Ok(court);
        }


        // POST api/<CourtCaseController>
        [HttpPost]
        public void Post([FromBody] CourtCase value)
        {
            _service.Post(value);
        }

        // PUT api/<CourtCaseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CourtCase value)
        {
            var res = _service.Put(id, value);
            if(res ==null)
                return NotFound();
            return Ok();
        }


        [HttpPut("{id}/status")]
        public ActionResult Put(int id, [FromBody] CourtStatus status)
        {
            var res = _service.Put(id, status);
            if (res == null)
                return NotFound();
            return Ok();
        }
    }
}
