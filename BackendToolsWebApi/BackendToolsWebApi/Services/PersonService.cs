using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendToolsWebApi.Models;
using BackendToolsWebApi.Repositories;

namespace BackendToolsWebApi.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person person)
        {
            return _personRepository.Create(person);
        }

        public List<Person> Read()
        {
            return _personRepository.Read();
        }

        public Person Read(int id)
        {
            return _personRepository.Read(id);
        }

        public List<Person> Read(string name)
        {
            return _personRepository.Read(name);
        }

        public Person Update(int id, Person person)
        {
            return _personRepository.Update(id, person);
        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }
    }
}
