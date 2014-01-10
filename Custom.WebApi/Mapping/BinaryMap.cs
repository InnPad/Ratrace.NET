using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class BinaryMap :  EntityTypeConfiguration<Binary>
    {
        public BinaryMap()
        {
            HasKey(o => o.Key);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(o => o.Stream)
                .HasColumnOrder(2)
                .IsMaxLength()
                .IsOptional()
                .IsVariableLength();

            ToTable(Pluralization.Binaries);
        }
    }
}
