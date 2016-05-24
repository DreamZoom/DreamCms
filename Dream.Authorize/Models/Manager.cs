using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream.Authorize
{
    public class Manager :EntityBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string RoleName { get; set; }
    }
}
