using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class TrackMapping : ClassMap<Track>
{
    public TrackMapping()
    {
        Table("TRACK");

        Id(track => track.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(track => track.Bonus, "BONUS").Scale(2);
        Map(track => track.Name, "NAME");
        Map(track => track.Team, "TEAM");

        HasMany(track => track.Transitions).KeyColumn("TRACK_ID").LazyLoad();
        HasMany(track => track.RequiredRaces).KeyColumn("TRACK_ID").Cascade.AllDeleteOrphan().LazyLoad();
        HasMany(track => track.RequiredClasses).KeyColumn("TRACK_ID").Cascade.AllDeleteOrphan().LazyLoad();
    }
}
