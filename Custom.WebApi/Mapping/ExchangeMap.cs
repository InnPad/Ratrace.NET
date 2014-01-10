using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Custom.Mapping
{
    using Custom.Social;

    public class ExchangeMap : EntityTypeConfiguration<Exchange>
    {
        public ExchangeMap()
        {
            HasKey(o => o.Id);

            HasRequired(o => o.Sender)
                .WithMany(o => o.Outbox)
                .Map(x => x.MapKey("Sender"))
                .WillCascadeOnDelete(false);

            HasRequired(o => o.Recipient)
                .WithMany(o => o.Outbox)
                .Map(x => x.MapKey("Recipient"))
                .WillCascadeOnDelete(false);

            HasRequired(o => o.Message)
                .WithMany()
                .Map(x => x.MapKey("Message"))
                .WillCascadeOnDelete(false);

            Property(o => o.SentOn)
                .IsRequired();

            Property(o => o.SeenOn)
                .IsRequired();
        }
    }
}