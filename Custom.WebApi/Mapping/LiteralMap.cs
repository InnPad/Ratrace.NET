using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class LiteralMap : EntityTypeConfiguration<Literal>
    {
        public LiteralMap()
        {
            Property(o => o.Length);

            Property(o => o.IsFixed);

            Property(o => o.Unicode);

            Property(o => o.Regex)
                .HasMaxLength(200)
                .IsVariableLength()
                .IsOptional()
                .IsUnicode(false);

            ToTable(Pluralization.Literals);
        }
    }
}
