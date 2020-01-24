using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResApiCore.Business;
using ResApiCore.Model;

namespace ResApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IProfileBusiness _profileBusiness;

        public ProfileController(IProfileBusiness profileBusiness)
        {
            _profileBusiness = profileBusiness;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_profileBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _profileBusiness.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Profile profile)
        {
            if (profile == null) return BadRequest();
            return new ObjectResult(_profileBusiness.Create(profile));
        }

        [HttpPut]
        public IActionResult Put([FromBody]Profile profile)
        {
            if (profile == null) return BadRequest();
            return new ObjectResult(_profileBusiness.Update(profile));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _profileBusiness.Delete(id);
            return NoContent();
        }
    }
}