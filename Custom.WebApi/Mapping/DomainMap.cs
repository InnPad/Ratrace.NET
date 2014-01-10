using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custom.Mapping
{
    using Custom.Entities;

    internal class DomainMap : EntityTypeConfiguration<Domain>
    {
        public DomainMap()
        {
            HasOptional(o => o.Principal)
                .WithMany(o => o.Dependencies)
                .Map(x => x.MapKey("Principal"))
                .WillCascadeOnDelete(false);

            HasMany(o => o.Members)
               .WithOptional(o => o.Domain)
               .Map(x => x.MapKey("Domain"))
               .WillCascadeOnDelete(false);

            ToTable(Pluralization.Domains);
        }
    }
}
