using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class PlaceMap : EntityTypeConfiguration<Place>
    {
        public PlaceMap()
        {
            HasKey(o => o.Key);

            HasOptional(o => o.Primary)
                .WithMany(o => o.Dependencies)
                .Map(x => x.MapKey("Primary"))
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

            /*Property(o => o.Location)
                .IsOptional();*/

            ToTable(Pluralization.Places);
        }
    }
}
