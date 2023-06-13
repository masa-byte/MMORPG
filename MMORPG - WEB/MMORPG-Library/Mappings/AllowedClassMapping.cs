using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class AllowedClassMapping : ClassMap<AllowedClass>
{

    public AllowedClassMapping()
    {
        Table("ALLOWED_CLASS");

        Id(allowedClass => allowedClass.Id).GeneratedBy.TriggerIdentity();

        Map(allowedClass => allowedClass.ClassName, "CLASS_NAME");

        References(allowedClass => allowedClass.Item).Column("ITEM_ID").LazyLoad();
    }

}
