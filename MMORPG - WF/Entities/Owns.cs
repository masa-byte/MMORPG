#nullable disable
namespace MMORPG.Entities;

public class Owns
{
    public virtual int Id { get; set; }

    public virtual Player Player { get; set; }

    public virtual Item Item { get; set; }
}
