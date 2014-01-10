using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Custom.Mapping
{
    using Custom.Social;

    public class IdentityMap : EntityTypeConfiguration<Identity>
    {
        public IdentityMap()
        {
            HasKey(o => o.Id);

            HasMany(o => o.Contacts)
                .WithOptional(o => o.Identity)
                .Map(x => x.MapKey("Identity"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Sessions)
                .WithOptional(o => o.Identity)
                .Map(x => x.MapKey("Identity"))
                .WillCascadeOnDelete(false);
        }
    }
}