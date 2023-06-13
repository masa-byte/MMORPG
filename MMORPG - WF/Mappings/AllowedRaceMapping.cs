using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class AllowedRaceMapping : ClassMap<AllowedRace>
{

    public AllowedRaceMapping()
    {
        Table("ALLOWED_RACE");

        Id(allowedRace => allowedRace.Id).GeneratedBy.TriggerIdentity();

        Map(allowedRace => allowedRace.RaceName, "RACE_NAME");

        References(allowedRace => allowedRace.Item).Column("ITEM_ID").LazyLoad();
    }

}
