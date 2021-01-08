using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class ModelEffectiveDetailMapConfig : EntityMappingConfiguration<ModelEffectiveDetail>
    {
        public override void Map(EntityTypeBuilder<ModelEffectiveDetail>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

