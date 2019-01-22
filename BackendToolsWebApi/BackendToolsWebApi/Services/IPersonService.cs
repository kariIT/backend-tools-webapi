using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendToolsWebApi.Models;

namespace BackendToolsWebApi.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        List<Person> Read();
        Person Read(int id);
        List<Person> Read(string name);
        Person Update(int id, Person person);
        void Delete(int id);

    }
}
