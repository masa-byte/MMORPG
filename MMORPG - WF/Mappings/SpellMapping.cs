using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class SpellMapping : ClassMap<Spell>
{
    public SpellMapping()
    {
        Table("SPELL");

        Id(spell => spell.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(spell => spell.Name, "NAME");

        HasMany(spell => spell.CastByWizards).KeyColumn("SPELL_ID").LazyLoad();
    }
}
