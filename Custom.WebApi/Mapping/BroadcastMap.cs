using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Custom.Mapping
{
    using Custom.Social;

    public class BroadcastMap : EntityTypeConfiguration<Broadcast>
    {
        public BroadcastMap()
        {
            HasKey(o => o.Id);

            HasRequired(o => o.Circle)
                .WithMany(o => o.Broadcasts)
                .Map(x => x.MapKey("Broadcast"))
                .WillCascadeOnDelete(false);

            HasRequired(o => o.Message)
                .WithMany()
                .Map(x => x.MapKey("Message"))
                .WillCascadeOnDelete(false);

            HasRequired(o => o.Sender)
                .WithMany(o => o.Feeds)
                .Map(x => x.MapKey("Sender"))
                .WillCascadeOnDelete(false);

            Property(o => o.SentOn)
                .IsRequired();
        }
    }
}