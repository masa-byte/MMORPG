using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class RequiredClassMapping : ClassMap<RequiredClass>
{
    public RequiredClassMapping()
    {
        Table("REQUIRED_CLASS");

        Id(requiredClass => requiredClass.Id).GeneratedBy.TriggerIdentity();

        Map(requiredClass => requiredClass.ClassName, "CLASS_NAME");

        References(requiredClass => requiredClass.Track).Column("TRACK_ID").LazyLoad();
    }
}
