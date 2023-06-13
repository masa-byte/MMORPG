using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class ArcherMapping : SubclassMap<Archer>
{
    public ArcherMapping()
    {
        Table("ARCHER");

        KeyColumn("CHARACTER_ID");

        Map(archer => archer.BowCrossbow).Column("BOW_CROSSBOW");
    }
}
