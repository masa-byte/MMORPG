using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class TransitMapping : ClassMap<Transit>
{
    public TransitMapping()
    {
        Table("TRANSIT");

        Id(transit => transit.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(transit => transit.Successful, "\"SUCCESSFUL\"");
        Map(transit => transit.EnemiesDefeated, "ENEMIES_DEFEATED");

        References(transit => transit.Team).Column("TEAM_ID").LazyLoad();
        References(transit => transit.Player).Column("PLAYER_ID").LazyLoad();
        References(transit => transit.Track).Column("TRACK_ID").LazyLoad();
    }
}
