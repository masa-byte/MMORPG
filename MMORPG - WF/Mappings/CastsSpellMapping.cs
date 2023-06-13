using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class CastsSpellMapping : ClassMap<CastsSpell>
{
    public CastsSpellMapping()
    {
        Table("CASTS_SPELL");

        Id(castsSpell => castsSpell.Id).GeneratedBy.TriggerIdentity();

        References(castsSpell => castsSpell.Spell).Column("SPELL_ID").LazyLoad();
        References(castsSpell => castsSpell.Wizard).Column("WIZARD_ID").LazyLoad();
    }
}
