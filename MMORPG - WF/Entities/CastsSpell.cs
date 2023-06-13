#nullable disable
namespace MMORPG.Entities;

public class CastsSpell
{
    public virtual int Id { get; set; }

    public virtual Spell Spell { get; set; }

    public virtual Wizard Wizard { get; set; }
}
