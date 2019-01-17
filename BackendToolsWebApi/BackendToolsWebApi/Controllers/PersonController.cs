using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendToolsWebApi.Models;
using BackendToolsWebApi.Repositories;

namespace BackendToolsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        // GET: api/person
        [HttpGet]
        public ActionResult<List<Person>> GetPersons()
        {
            List<Person> persons = _personRepository.Read();
            return new JsonResult(persons);
        }
        
        // GET: api/person/{name}
        [HttpGet("{name}")]
        public ActionResult<List<Person>> GetPersonsByName(string name)
        {
            List<Person> persons = _personRepository.Read(name);
            return new JsonResult(persons);
        }

        // POST: api/person
        [HttpPost]
        public ActionResult<Person> Create(Person person)
        {
            return _personRepository.Create(person);
        }

        // PUT: api/person/{id}
        [HttpPut("{id}")]
        public ActionResult<Person> Update(int id, Person person)
        {
            Person updatePerson = _personRepository.Update(id, person);
            return new JsonResult(updatePerson);
        }

        // DELETE: api/person/{id}
        [HttpDelete("{id}")]
        public ActionResult<Person> Delete(int id)
        {
            _personRepository.Delete(id);
            return new OkResult();
        }
    }
}
