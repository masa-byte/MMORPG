using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class DefenderMapping : SubclassMap<Defender>
{
    public DefenderMapping()
    {
        Table("DEFENDER");

        KeyColumn("CHARACTER_ID");

        Map(defender => defender.MaxArmourWeight).Column("MAX_ARMOUR_WEIGHT");
    }
}
