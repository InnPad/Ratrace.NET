using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Custom.Containers
{
    using Custom.Mapping;
    using Custom.Social;

    public class SocialDbContext : DbContext
    {
        public SocialDbContext()
            : base("name=SocialDbContext")
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Circle> Circles { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Broadcast> Broadcasts { get; set; }
        public DbSet<Session> Sessions { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations
                .Add(new IdentityMap())
                .Add(new CircleMap())
                .Add(new ContactMap())
                .Add(new MessageMap())
                .Add(new ExchangeMap())
                .Add(new BroadcastMap())
                .Add(new SessionMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}