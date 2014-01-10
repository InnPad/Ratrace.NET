using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class DefinitionMap : EntityTypeConfiguration<Definition>
    {
        public DefinitionMap()
        {
            HasKey(o => o.Key);

            HasOptional(o => o.Area)
                .WithMany(o => o.Types)
                .Map(x => x.MapKey("Area"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Term)
                .WithMany()
                .Map(x => x.MapKey("Term"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                //.HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Name)
                //.HasColumnOrder(2)
                .HasMaxLength(DictionaryContext.NameMaxLength)
                .IsOptional()
                .IsVariableLength()
                .IsUnicode(false);

            Property(o => o.Id)
                //.HasColumnOrder(3)
                .IsOptional()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            /*Map<Definition>(o => o.Requires(x => x.DefinitionType)
                .HasValue())
                .*/
            ToTable(Pluralization.Definitions);
            /*.ToTable(Pluralization.VariantTableName);

        Map<Literal>(o => o.Requires("VariantType")
            .HasValue((byte)VariantType.Literal))
            .ToTable(Pluralization.LiteralTableName);

        Map<Number>(o => o.Requires("VariantType")
            .HasValue((byte)VariantType.Number))
            .ToTable(Pluralization.NumberTableName);

        Map<Domain>(o => o.Requires("VariantType")
            .HasValue((byte)VariantType.Domain))
            .ToTable(Pluralization.DomainTableName);

        Map<Prototype>(o => o.Requires("VariantType")
             .HasValue((byte)VariantType.Prototype))
             .ToTable(Pluralization.PrototypeTableName);*/
        }
    }
}
