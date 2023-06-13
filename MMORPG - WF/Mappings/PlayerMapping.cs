using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class PlayerMapping : ClassMap<Player>
{

    public PlayerMapping()
    {

        Table("PLAYER");

        Id(player => player.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(player => player.Nickname, "NICKNAME");
        Map(player => player.Password, "PASSWORD");
        Map(player => player.Name, "NAME");
        Map(player => player.Surname, "SURNAME");
        Map(player => player.Gender, "GENDER");
        Map(player => player.Age, "AGE");

        HasMany(player => player.Characters).KeyColumn("PLAYER_ID").LazyLoad();
        HasMany(player => player.Sessions).KeyColumn("PLAYER_ID").LazyLoad();
        References(player => player.Team).Column("TEAM_ID").LazyLoad();
        HasMany(player => player.Transitions).KeyColumn("PLAYER_ID").LazyLoad();
        HasMany(player => player.OwnsItems).KeyColumn("PLAYER_ID").LazyLoad();
    }

}
