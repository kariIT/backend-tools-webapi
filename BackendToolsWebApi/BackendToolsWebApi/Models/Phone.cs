﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendToolsWebApi.Models
{
    public partial class Phone
    {
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
