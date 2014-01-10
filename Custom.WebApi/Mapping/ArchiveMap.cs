using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class ArchiveMap :  EntityTypeConfiguration<Archive>
    {
        public ArchiveMap()
        {
            HasKey(o => o.Key);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(o => o.PathName)
                .HasColumnOrder(2)
                .HasMaxLength(500)
                .IsRequired()
                .IsVariableLength()
                .IsUnicode(false);

            ToTable(Pluralization.Archives);
        }
    }
}
