using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipes.BusinessLayer.Interfaces;
using Recipes.CoreLayer.Entities;

namespace Recipes.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IService<User> _service;

        public UsersController(IService<User> service)
        {
            _service = service;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetById(id));
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Add([FromBody] User user)
        {
            _service.Add(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] User user)
        {
            return Ok(_service.GetById(user.Id));
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
