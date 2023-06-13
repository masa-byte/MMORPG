using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class SessionMapping : ClassMap<Session>
{
    public SessionMapping()
    {
        Table("\"SESSION\"");

        Id(session => session.Id, "ID").GeneratedBy.TriggerIdentity();


        Map(session => session.StartTime)
            .Column("START_TIME")
            .CustomType("timestamp");
        Map(session => session.EndTime)
            .Column("END_TIME")
            .CustomType("timestamp");
        Map(session => session.Points, "POINTS").Scale(2);
        Map(session => session.Gold, "GOLD").Scale(2);

        References(session => session.Player).Column("PLAYER_ID").LazyLoad();
    }
}
