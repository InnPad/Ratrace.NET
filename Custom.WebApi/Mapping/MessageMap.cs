using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Custom.Mapping
{
    using Custom.Social;

    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            HasKey(o => o.Id);

            HasRequired(o => o.Author)
                .WithMany(o => o.Messages)
                .Map(x => x.MapKey("Identity"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Exchanges)
                .WithOptional(o => o.Message)
                .Map(x => x.MapKey("Message"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Broadcasts)
                .WithOptional(o => o.Message)
                .Map(x => x.MapKey("Message"))
                .WillCascadeOnDelete(false);

            Property(o => o.Content)
                .HasMaxLength(400)
                .IsRequired()
                .IsUnicode();
        }
    }
}