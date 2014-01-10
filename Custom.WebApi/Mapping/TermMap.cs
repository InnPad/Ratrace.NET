using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class TermMap : EntityTypeConfiguration<Term>
    {
        public TermMap()
        {
            HasKey(o => o.Key);

            HasOptional(o => o.Archive)
                .WithMany()
                .Map(x => x.MapKey("Archive"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Culture)
                .WithMany()
                .Map(x => x.MapKey("Culture"))
                .WillCascadeOnDelete(false);

            HasRequired(o => o.Termbase)
                .WithMany(o => o.Terms)
                .Map(x => x.MapKey("Termbase"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Principal)
                .WithMany(o => o.Dependencies)
                .Map(x => x.MapKey("Principal"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Content)
                .WithRequired(o => o.Term)
                .Map(x => x.MapKey("Term"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Index)
                .HasColumnOrder(2)
                .HasColumnName("Index")
                .IsOptional();

            Property(o => o.Value)
                .HasColumnOrder(3)
                .HasColumnName("Text")
                .HasMaxLength(DictionaryContext.TextMaxLength)
                .IsOptional()
                .IsVariableLength()
                .IsUnicode(true);


            ToTable(Pluralization.Terms);
        }
    }
}
