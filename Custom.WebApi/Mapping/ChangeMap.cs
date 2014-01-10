using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class ChangeMap : EntityTypeConfiguration<Change>
    {
        public ChangeMap()
        {
            HasKey(o => o.Version);

            HasOptional(o => o.Field)
                .WithMany(o => o.Changes)
                .Map(x => x.MapKey("Field"))
                .WillCascadeOnDelete(false);

            Property(o => o.Version)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Previous)
                .HasColumnOrder(3)
                .HasMaxLength(DictionaryContext.ValueMaxLength)
                .IsOptional()
                .IsVariableLength()
                .IsUnicode(true);

            Property(o => o.ChangedBy)
                .HasColumnOrder(4)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsRequired();

            Property(o => o.ChangedOn)
                .HasColumnOrder(5)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsRequired();

            ToTable(Pluralization.Changes);
        }
    }
}
