using BL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutesController : ControllerBase
    {
        IinstitutesBL IinstitutesBL;
        public InstitutesController(IinstitutesBL IinstitutesBL)
        {
            this.IinstitutesBL = IinstitutesBL;
        }
        // GET: api/<InstitutesController>
        [HttpGet]
        public async Task<ActionResult<List<Institutes>>> Get()
        {
            List<Institutes> institutes = await IinstitutesBL.getAllInstitutes();
            if (institutes == null)
                return NoContent();
            return institutes;
        }


        // GET api/<InstitutesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InstitutesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InstitutesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InstitutesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
