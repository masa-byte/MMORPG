using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class UsesBlessingMapping : ClassMap<UsesBlessing>
{
    public UsesBlessingMapping()
    {
        Table("USES_BLESSING");

        Id(usesBlessing => usesBlessing.Id).GeneratedBy.TriggerIdentity();

        References(usesBlessing => usesBlessing.Blessing).Column("BLESSING_ID").LazyLoad();
        References(usesBlessing => usesBlessing.Priest).Column("PRIEST_ID").LazyLoad();
    }
}
