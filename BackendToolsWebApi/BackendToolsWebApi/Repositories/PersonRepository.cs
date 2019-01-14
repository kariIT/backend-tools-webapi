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

        // CREATE PERSON person;
        public Person Create(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
            Console.WriteLine("PERSON CREATED", person.Name, person.Age);
            return person;
        }

        // SELECT * FROM PERSON;
        public List<Person> Read()
        {
            return _context.Person.Include(p => p.Phone).ToList();
        }

        // SELECT * FROM PERSON WHERE ID={id};
        public Person Read(int id)
        {
            return _context.Person.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        // UPDATE PERSON person;
        public Person Update(int id, Person person)
        {
            var check = Read(id);

            if (check == person)
            {
                throw new Exception("Person not found.");
            }

            _context.Person.Update(person);
            _context.SaveChanges();

            Console.WriteLine("PERSON UPDATED: " + "ID: " + person.Id + " NAME: " + person.Name);
            return person;
        }

        public void Delete(int id)
        {
            var person = Read(id);
            _context.Person.Remove(person);
            _context.SaveChanges();
            Console.WriteLine("PERSON DELETED: " + person.Id + " " + person.Name);
        }
    }
}
