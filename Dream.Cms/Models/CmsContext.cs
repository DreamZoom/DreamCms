using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Dream.Cms
{
    public class CmsContext : DbContext
    {
        public CmsContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CmsContext,Configuration<CmsContext>>()); 
        }
        public DbSet<Article> Articles { get; set; }

        public DbSet<Channel> Categorys { get; set; }

        public DbSet<FriendLink> Links { get; set; }

    }
}
