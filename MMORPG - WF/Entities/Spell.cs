#nullable disable
namespace MMORPG.Entities;

public class Spell
{
    public virtual int Id { get; set; }

    public virtual string Name { get; set; }

    public virtual IList<CastsSpell> CastByWizards { get; set; }

    public Spell()
    {
        CastByWizards = new List<CastsSpell>();
    }
}
