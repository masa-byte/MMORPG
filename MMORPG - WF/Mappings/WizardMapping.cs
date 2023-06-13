using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class WizardMapping : SubclassMap<Wizard>
{
    public WizardMapping()
    {
        Table("WIZARD");

        KeyColumn("CHARACTER_ID");

        HasMany(wizzard => wizzard.CastsSpells).KeyColumn("WIZARD_ID").Cascade.All().Inverse().LazyLoad();
    }
}
