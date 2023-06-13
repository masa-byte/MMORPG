using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class OwnsMapping : ClassMap<Owns>
{

    public OwnsMapping()
    {
        Table("OWNS");

        Id(owns => owns.Id).GeneratedBy.TriggerIdentity();

        References(owns => owns.Player).Column("PLAYER_ID").LazyLoad();
        References(owns => owns.Item).Column("ITEM_ID").LazyLoad();
    }

}
