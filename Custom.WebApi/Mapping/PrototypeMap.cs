using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class PrototypeMap : EntityTypeConfiguration<Prototype>
    {
        public PrototypeMap()
        {
            HasMany(o => o.Entities)
                .WithRequired(o => o.Prototype)
                .WillCascadeOnDelete(false);

            HasMany(o => o.Properties)
                .WithRequired(o => o.Prototype)
                .WillCascadeOnDelete(false);

            ToTable(Pluralization.Prototypes);
        }
    }
}
