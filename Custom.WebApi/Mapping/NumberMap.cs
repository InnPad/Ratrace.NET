using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class NumberMap : EntityTypeConfiguration<Number>
    {
        public NumberMap()
        {
            Property(o => o.DecimalDigits)
                .IsOptional();

            Property(o => o.DecimalSeparator)
                .HasMaxLength(1)
                .IsFixedLength()
                .IsOptional();

            Property(o => o.GroupSeparator)
                .HasMaxLength(1)
                .IsFixedLength()
                .IsOptional();

            Property(o => o.Maximum)
                .IsOptional();

            Property(o => o.Minimum)
                .IsOptional();

            Property(o => o.Padding)
                .IsRequired();

            Property(o => o.Precision)
                .IsOptional();

            Property(o => o.Scale)
                .IsOptional();

            Property(o => o.Format)
                .HasMaxLength(DictionaryContext.ValueMaxLength)
                .IsOptional()
                .IsVariableLength()
                .IsUnicode(false);

            ToTable(Pluralization.Numbers);
        }
    }
}
