using System;
using System.Collections.Generic;

namespace BackendToolsWebApi.Models
{
    public partial class Phone
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
        public long? PersonId { get; set; }

        public Person Person { get; set; }
    }
}
