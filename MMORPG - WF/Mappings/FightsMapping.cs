using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class FightsMapping : ClassMap<Fights>
{
    public FightsMapping()
    {
        Table("FIGHTS");

        Id(fights => fights.Id, "ID").GeneratedBy.TriggerIdentity();


        Map(fights => fights.TimeHeld)
            .Column("TIME_HELD")
            .CustomType("timestamp");
        Map(fights => fights.Bonus, "BONUS").Scale(2);
        Map(fights => fights.WinningTeam, "WINNING_TEAM");

        References(fights => fights.Team1).Column("TEAM1_ID").LazyLoad();
        References(fights => fights.Team2).Column("TEAM2_ID").LazyLoad();
    }
}
