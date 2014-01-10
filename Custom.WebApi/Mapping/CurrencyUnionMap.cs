using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class CurrencyUnionMap : EntityTypeConfiguration<CurrencyUnion>
    {
        public CurrencyUnionMap()
        {
            HasKey(o => o.Key);

            HasRequired(o => o.Currency)
                .WithMany()
                .Map(x => x.MapKey("Currency"))
                .WillCascadeOnDelete(false);

            HasRequired(o => o.Region)
                .WithMany()
                .Map(x => x.MapKey("Region"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Primary)
                .HasColumnOrder(2)
                .IsRequired();

            ToTable(Pluralization.CurrencyUnions);
        }
    }
}
