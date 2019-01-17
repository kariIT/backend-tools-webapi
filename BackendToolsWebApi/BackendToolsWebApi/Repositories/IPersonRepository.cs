using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendToolsWebApi.Models;

namespace BackendToolsWebApi.Repositories
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        List<Person> Read();
        List<Person> Read(string name);
        Person Update(int id, Person person);
        void Delete(int id);
    }
}
