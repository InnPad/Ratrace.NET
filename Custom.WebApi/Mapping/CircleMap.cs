using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Custom.Mapping
{
    using Custom.Social;

    public class CircleMap : EntityTypeConfiguration<Circle>
    {
        public CircleMap()
        {
            HasKey(o => o.Id);

            HasMany(o => o.Contacts)
                .WithRequired(o => o.Circle)
                .Map(x => x.MapKey("Circle"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Broadcasts)
                .WithRequired(o => o.Circle)
                .Map(x => x.MapKey("Circle"))
                .WillCascadeOnDelete(false);
        }
    }
}