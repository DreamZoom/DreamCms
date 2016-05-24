using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Dream.Authorize
{
    public class AuthorizeContext : DbContext
    {
        public AuthorizeContext()
            : base("Authorize")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }

        public DbSet<Authority> Authoritys { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Manager> Managers { get; set; }
    }
}
