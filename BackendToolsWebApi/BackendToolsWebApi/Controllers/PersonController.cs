using BackendToolsWebApi.Models;
using BackendToolsWebApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BackendToolsWebApi.Services;

namespace BackendToolsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: api/person
        [HttpGet]
        public ActionResult<List<Person>> GetPersons()
        {
            List<Person> persons = _personService.Read();
            return new JsonResult(persons);
        }
        
        // GET: api/person/{name}
        [HttpGet("{name}")]
        public ActionResult<List<Person>> GetPersonsByName(string name)
        {
            List<Person> persons = _personService.Read(name);
            return new JsonResult(persons);
        }

        // POST: api/person
        [HttpPost]
        public ActionResult<Person> Create(Person person)
        {
            return _personService.Create(person);
        }

        // PUT: api/person/{id}
        [HttpPut("{id}")]
        public ActionResult<Person> Update(int id, Person person)
        {
            Person updatePerson = _personService.Update(id, person);
            return new JsonResult(updatePerson);
        }

        // DELETE: api/person/{id}
        [HttpDelete("{id}")]
        public ActionResult<Person> Delete(int id)
        {
            _personService.Delete(id);
            return new OkResult();
        }
    }
}
