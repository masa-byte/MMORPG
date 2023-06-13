#nullable disable
namespace MMORPG.Entities;

public class Blessing
{
    public virtual int Id { get; set; }

    public virtual string Name { get; set; }

    public virtual IList<UsesBlessing> UsedByPriests { get; set; }

    public Blessing()
    {
        UsedByPriests = new List<UsesBlessing>();
    }
}
