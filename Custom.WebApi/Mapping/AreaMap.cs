using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            HasKey(o => o.Key);

            HasOptional(o => o.Principal)
                .WithMany(o => o.Dependencies)
                .Map(x => x.MapKey("Principal"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Term)
                .WithMany()
                .Map(x => x.MapKey("Term"))
                .WillCascadeOnDelete(false);

            HasRequired(o => o.Termbase)
                .WithMany()
                .Map(x => x.MapKey("Termbase"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Types)
                .WithOptional(o => o.Area)
                .Map(x => x.MapKey("Area"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Name)
                .HasColumnOrder(2)
                .HasMaxLength(DictionaryContext.NameMaxLength)
                .IsOptional()
                .IsVariableLength()
                .IsUnicode(false);

            ToTable(Pluralization.Areas);
        }
    }
}
