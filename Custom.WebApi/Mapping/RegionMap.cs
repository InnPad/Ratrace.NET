using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            HasOptional(o => o.Currency)
                .WithOptionalDependent(o => o.Origen)
                .Map(x => x.MapKey("Currency"))
                .WillCascadeOnDelete(false);

            Property(o => o.Iso)
                //.HasColumnOrder(2)
                .HasMaxLength(DictionaryContext.NameMaxLength)
                .IsRequired()
                .IsVariableLength()
                .IsUnicode(false);

            ToTable(Pluralization.Regions);
        }
    }
}
