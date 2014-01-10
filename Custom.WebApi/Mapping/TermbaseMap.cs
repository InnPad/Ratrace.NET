using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class TermbaseMap : EntityTypeConfiguration<Termbase>
    {
        public TermbaseMap()
        {
            HasKey(o => o.Key);

            HasMany(o => o.Terms)
                .WithRequired(o => o.Termbase)
                .Map(x => x.MapKey("Termbase"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                //.HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Name)
                //.HasColumnOrder(2)
                .HasMaxLength(DictionaryContext.NameMaxLength)
                .IsOptional()
                .IsVariableLength()
                .IsUnicode(false);

            ToTable(Pluralization.Termbases);
        }
    }
}
