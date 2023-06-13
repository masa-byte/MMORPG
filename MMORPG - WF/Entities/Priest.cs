#nullable disable
namespace MMORPG.Entities;

public class Priest : Character
{
    public virtual string Religion { get; set; }
    public virtual char Heals { get; set; }

    public virtual IList<UsesBlessing> UsesBlessings { get; set; }

    public Priest()
    {
        UsesBlessings = new List<UsesBlessing>();
    }
}
