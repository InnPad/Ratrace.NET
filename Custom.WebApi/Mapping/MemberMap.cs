using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            HasKey(o => o.Key);

            HasOptional(o => o.Domain)
                .WithMany(o => o.Members)
                .Map(x => x.MapKey("Domain"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Term)
                .WithMany()
                .Map(x => x.MapKey("Term"))
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

            Property(o => o.Value)
                .HasColumnOrder(3)
                .HasMaxLength(DictionaryContext.ValueMaxLength)
                .IsOptional()
                .IsVariableLength()
                .IsUnicode(true);

            ToTable(Pluralization.Members);
        }
    }
}
