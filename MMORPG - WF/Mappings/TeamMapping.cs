using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class TeamMapping : ClassMap<Team>
{

    public TeamMapping()
    {
        Table("TEAM");

        Id(team => team.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(team => team.Name, "NAME");
        Map(team => team.MaxPlayers, "MAX_PLAYERS");
        Map(team => team.MinPlayers, "MIN_PLAYERS");
        Map(team => team.BonusPoints, "BONUS_POINTS").Scale(2);
        Map(team => team.Placement, "PLACEMENT").Scale(2);

        HasMany(team => team.Players).KeyColumn("TEAM_ID").LazyLoad();
        HasMany(team => team.Transitions).KeyColumn("TEAM_ID").LazyLoad();
        HasMany(team => team.Teams1).KeyColumn("TEAM1_ID").LazyLoad();
        HasMany(team => team.Teams2).KeyColumn("TEAM2_ID").LazyLoad();
    }

}
