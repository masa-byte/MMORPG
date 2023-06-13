using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class PriestMapping : SubclassMap<Priest>
{
    public PriestMapping()
    {
        Table("PRIEST");

        KeyColumn("CHARACTER_ID");

        Map(priest => priest.Heals).Column("HEALS");
        Map(priest => priest.Religion).Column("RELIGION");

        HasMany(priest => priest.UsesBlessings).KeyColumn("PRIEST_ID").Cascade.All().Inverse().LazyLoad();
    }
}
