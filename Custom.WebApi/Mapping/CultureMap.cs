using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class CultureMap : EntityTypeConfiguration<Culture>
    {
        public CultureMap()
        {
            HasKey(o => o.Key);

            HasOptional(o => o.Primary)
                .WithMany()
                .Map(x => x.MapKey("Parent"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Region)
                .WithMany(o => o.Cultures)
                .Map(x => x.MapKey("Region"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Term)
                .WithMany()
                .Map(x => x.MapKey("Term"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Iso)
                .HasColumnOrder(2)
                .HasMaxLength(11)
                .IsRequired()
                .IsVariableLength()
                .IsUnicode(false);

            Property(o => o.Name)
                .HasColumnOrder(3)
                .HasMaxLength(50)
                .IsRequired()
                .IsVariableLength()
                .IsUnicode(false);

            ToTable(Pluralization.Cultures);
        }
    }
}
