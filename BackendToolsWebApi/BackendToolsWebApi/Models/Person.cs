﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendToolsWebApi.Models
{
    public partial class Person
    {
        public Person()
        {
            Phone = new HashSet<Phone>();
        }

        public Person(string name, short? age)
        {
            Name = name;
            Age = age;
        }

        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public short? Age { get; set; }

        [InverseProperty("Person")]
        public ICollection<Phone> Phone { get; set; }
    }
}
