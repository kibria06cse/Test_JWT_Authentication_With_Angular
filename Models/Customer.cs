﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_JWT_Authentication_With_Angular.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }  // navigation property
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }
    }
}
