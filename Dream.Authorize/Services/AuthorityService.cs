using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream.Authorize
{
    public class AuthorityService : EntityServiceBase<Authority>
    {
        public override System.Data.Entity.DbContext GetDbContext()
        {
            return new AuthorizeContext();
        }
    }
}
