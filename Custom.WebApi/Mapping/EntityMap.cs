using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class EntityMap : EntityTypeConfiguration<Entity>
    {
        public EntityMap()
        {
            HasKey(o => o.Key);

            HasRequired(o => o.Prototype)
                .WithMany(o => o.Entities)
                .Map(x => x.MapKey("Prototype"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Term)
                .WithMany()
                .Map(x => x.MapKey("Term"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            ToTable(Pluralization.Entities);
        }
    }
}
