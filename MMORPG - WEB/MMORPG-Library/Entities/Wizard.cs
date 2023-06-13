#nullable disable
namespace MMORPG.Entities;

public class Wizard : Character
{
    public virtual IList<CastsSpell> CastsSpells { get; set; }

    public Wizard()
    {
        CastsSpells = new List<CastsSpell>();
    }
}
