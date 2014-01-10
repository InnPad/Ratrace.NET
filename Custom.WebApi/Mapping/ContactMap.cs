using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Custom.Mapping
{
    using Custom.Social;

    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            HasKey(o => o.Id);

            HasRequired(o => o.Identity)
                .WithMany(o => o.Contacts)
                .Map(x => x.MapKey("Identity"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Inbox)
                .WithOptional(o => o.Recipient)
                .Map(x => x.MapKey("Recipient"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Outbox)
                .WithOptional(o => o.Sender)
                .Map(x => x.MapKey("Sender"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Feeds)
                .WithOptional(o => o.Sender)
                .Map(x => x.MapKey("Sender"))
                .WillCascadeOnDelete(false);
        }
    }
}