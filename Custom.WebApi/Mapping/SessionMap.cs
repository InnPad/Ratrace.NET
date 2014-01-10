using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Custom.Mapping
{
    using Custom.Social;

    public class SessionMap : EntityTypeConfiguration<Session>
    {
        public SessionMap()
        {
            HasKey(o => o.Id);

            HasOptional(o => o.Identity)
                .WithMany(o => o.Sessions)
                .Map(x => x.MapKey("Identity"))
                .WillCascadeOnDelete(false);

            Property(o => o.Since)
                .IsRequired();

            Property(o => o.Until)
                .IsOptional();
        }
    }
}