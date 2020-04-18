using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_JWT_Authentication_With_Angular.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
