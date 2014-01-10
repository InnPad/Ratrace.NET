using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class PropertyMap : EntityTypeConfiguration<Property>
    {
        public PropertyMap()
        {
            HasKey(o => o.Key);

            HasRequired(o => o.Prototype)
                .WithMany(o => o.Properties)
                .Map(x => x.MapKey("Prototype"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Term)
                .WithMany()
                .Map(x => x.MapKey("Term"))
                .WillCascadeOnDelete(false);

            HasRequired(o => o.Type)
                .WithMany()
                .Map(x => x.MapKey("Type"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Name)
                .HasColumnOrder(2)
                .HasMaxLength(DictionaryContext.NameMaxLength)
                .IsOptional()
                .IsVariableLength()
                .IsUnicode(false);
            
            Property(o => o.FieldName)
                .HasColumnOrder(3)
                .HasMaxLength(DictionaryContext.NameMaxLength)
                .IsRequired()
                .IsVariableLength()
                .IsUnicode(false);

            ToTable(Pluralization.Properties);
        }
    }
}
