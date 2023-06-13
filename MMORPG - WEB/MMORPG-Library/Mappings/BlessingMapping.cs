using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class BlessingMapping : ClassMap<Blessing>
{
    public BlessingMapping()
    {
        Table("BLESSING");

        Id(blessing => blessing.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(blessing => blessing.Name, "NAME");

        HasMany(blessing => blessing.UsedByPriests).KeyColumn("BLESSING_ID").LazyLoad();
    }
}
