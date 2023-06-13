using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class FighterMapping : SubclassMap<Fighter>
{
    public FighterMapping()
    {
        Table("FIGHTER");

        KeyColumn("CHARACTER_ID");

        Map(fighter => fighter.Shield).Column("SHIELD");
        Map(fighter => fighter.TwohandedWeapon).Column("TWOHANDED_WEAPON");
    }
}
