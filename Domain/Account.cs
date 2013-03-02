﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Company { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }
        public virtual List<Repair> Repairs { get; set; }
    }
}
