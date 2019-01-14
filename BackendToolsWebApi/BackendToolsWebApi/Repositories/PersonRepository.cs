using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendToolsWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendToolsWebApi.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersondbContext _context;

        public PersonRepository(PersondbContext context)
        {
            _context = context;
        }
        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        // SELECT * FROM PERSON;
        public List<Person> Read()
        {
            return _context.Person.ToList();
        }

        // SELECT * FROM PERSON WHERE ID={id};
        public Person Read(int id)
        {
            // == return true or false
            return _context.Person.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        public Person Update(int id, Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
