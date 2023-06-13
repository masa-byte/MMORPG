#nullable disable
namespace MMORPG.Entities;

public class UsesBlessing
{
    public virtual int Id { get; set; }

    public virtual Blessing Blessing { get; set; }

    public virtual Priest Priest { get; set; }
}
