using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class CurrencyMap : EntityTypeConfiguration<Currency>
    {
        public CurrencyMap()
        {
            /*HasOptional(o => o.Origen)
                .WithOptionalPrincipal(o => o.Currency)
                .Map(x => x.MapKey("Origen"))
                .WillCascadeOnDelete(false);*/

            Property(o => o.GroupSizes)
                .HasMaxLength(9)
                .IsOptional()
                .IsVariableLength();

            ToTable(Pluralization.Currencies);
        }
    }
}
