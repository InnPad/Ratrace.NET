using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class MeasureMap : EntityTypeConfiguration<Measure>
    {
        public MeasureMap()
        {
            Property(o => o.Iso)
                .IsOptional();

            /*Property(o => o.Quantity)
                .IsRequired();*/

            Property(o => o.Symbol)
                .IsOptional();

            /*Map<Measure>(o => o.Requires(x => x.Quantity)
                .HasValue())
                .*/ToTable(Pluralization.Measures);            
        }
    }
}
