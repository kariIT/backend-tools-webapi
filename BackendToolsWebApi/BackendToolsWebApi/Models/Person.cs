using System;
using System.Collections.Generic;

namespace BackendToolsWebApi.Models
{
    public partial class Person
    {
        public Person()
        {
            Phone = new HashSet<Phone>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? Age { get; set; }

        public ICollection<Phone> Phone { get; set; }
    }
}
