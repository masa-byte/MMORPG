#nullable disable
namespace MMORPG.Entities;

public class AllowedRace
{

    public virtual int Id { get; set; }

    public virtual string RaceName { get; set; }

    public virtual Item Item { get; set; }

}
