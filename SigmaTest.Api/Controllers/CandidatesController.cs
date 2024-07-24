using Microsoft.AspNetCore.Mvc;
using SigmaTest.Service.Controllers.Entities;
using SigmaTest.Service.Logic;

namespace SigmaTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        public readonly CandidateService candidatesService;

        public CandidatesController(CandidateService candidatesService)
        {
            this.candidatesService = candidatesService;
        }

        // GET: api/Candidates
        [HttpGet]
        public IEnumerable<Candidate> Get()
        {
            return candidatesService.GetAll();
        }

        // GET: api/Candidates/5
        [HttpGet("{id}", Name = "Get")]
        public void Get(int id)
        {
            candidatesService.GetById(id); ;
        }

        // POST: api/Candidates
        [HttpPost]
        public void Post([FromBody] Candidate candidate)
        {
            candidatesService.Add(candidate);
        }

        // PUT: api/Candidates/5
        [HttpPut("{id}")]
        public void Put([FromBody] Candidate candidate)
        {
            candidatesService.Update(candidate);
        }

        // DELETE: api/Candidates/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            candidatesService.RemoveById(id);
        }
    }
}
