using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class RequiredRaceMapping : ClassMap<RequiredRace>
{
    public RequiredRaceMapping()
    {
        Table("REQUIRED_RACE");

        Id(requiredRace => requiredRace.Id).GeneratedBy.TriggerIdentity();

        Map(requiredRace => requiredRace.RaceName, "RACE_NAME");

        References(requiredRace => requiredRace.Track).Column("TRACK_ID").LazyLoad();
    }
}
