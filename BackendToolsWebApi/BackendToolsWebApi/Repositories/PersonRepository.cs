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

        // CREATE TYPE PERSON;
        public Person Create(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
            
            return person;
        }

        // SELECT * FROM PERSON;
        public List<Person> Read()
        {
            return _context.Person.Include(p => p.Phone).ToList();
            // return _context.Person.FromSql("SELECT PERSON.*, PHONE.*, " + 
            //                                "FROM PERSON INNER JOIN PHONE ON PERSON.ID = PHONE.PERSONID");
        }

        // SELECT FROM PERSON WHERE ID={id};
        public Person Read(int id)
        {
            return _context.Person.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        // UPDATE PERSON WHERE ID={id};
        public Person Update(int id, Person person)
        {
            var check = Read(id);

            if (check == person)
            {
                throw new Exception("Person not found.");
            }

            _context.Person.Update(person);
            _context.SaveChanges();

            return person;
        }

        // DELETE FROM PERSON WHERE ID={id};
        public void Delete(int id)
        {
            var person = Read(id);
            _context.Person.Remove(person);
            _context.SaveChanges();
            Console.WriteLine("PERSON DELETED: " + person.Id + " " + person.Name);
        }
    }
}
