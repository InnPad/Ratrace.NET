using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class ContentMap : EntityTypeConfiguration<Content>
    {
        public ContentMap()
        {
            HasKey(o => o.Key);

            HasRequired(o => o.Term)
                .WithMany(o => o.Content)
                .Map(x => x.MapKey("Term"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Index)
                .HasColumnOrder(2)
                .HasColumnName("Index")
                .IsRequired();

            Property(o => o.Text)
                .HasColumnOrder(3)
                .HasColumnName("Text")
                .HasMaxLength(DictionaryContext.BlockMaxLength)
                .IsVariableLength()
                .IsUnicode(true);

            ToTable(Pluralization.Contents);
        }
    }
}
