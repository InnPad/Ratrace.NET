using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class FieldMap :  EntityTypeConfiguration<Field>
    {
        public FieldMap()
        {
            HasKey(o => o.Key);

            HasRequired(o => o.Entity)
                .WithMany(o => o.Fields)
                .Map(x => x.MapKey("Term"))
                .WillCascadeOnDelete(true);

            HasRequired(o => o.Property)
                .WithMany()
                .Map(x => x.MapKey("Property"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Archive)
                .WithMany()
                .Map(x => x.MapKey("Archive"))
                .WillCascadeOnDelete(true);

            HasOptional(o => o.Binary)
                .WithMany()
                .Map(x => x.MapKey("Binary"))
                .WillCascadeOnDelete(true);

            HasOptional(o => o.Term)
                .WithMany()
                .Map(x => x.MapKey("Text"))
                .WillCascadeOnDelete(false);

            HasOptional(o => o.Type)
                .WithMany()
                .Map(x => x.MapKey("Type"))
                .WillCascadeOnDelete(false);

            Property(o => o.Key)
                //.HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.Index)
                //.HasColumnOrder(2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsOptional();

            Property(o => o.Value)
                //.HasColumnOrder(3)
                .IsOptional();

            Property(o => o.Complement)
                //.HasColumnOrder(4)
                .IsOptional();

           ToTable(Pluralization.Fields);
        }
    }
}
