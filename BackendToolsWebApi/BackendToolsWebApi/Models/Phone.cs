using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendToolsWebApi.Models
{
    public partial class Phone
    {
        public Phone(long id, long? personId)
        {
            Id = id;
            PersonId = personId;
        }

        public Phone(long id, string type, string number, long? personId, Person person)
        {
            Id = id;
            Type = type;
            Number = number;
            PersonId = personId;
            Person = person;
        }

        public long Id { get; set; }
        [StringLength(10)]
        public string Type { get; set; }
        [StringLength(10)]
        public string Number { get; set; }
        public long? PersonId { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Phone")]
        public Person Person { get; set; }
    }
}
