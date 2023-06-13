#nullable disable
namespace MMORPG.Entities;

public class RequiredRace
{
    public virtual int Id { get; set; }

    public virtual string RaceName { get; set; }

    public virtual Track Track { get; set; }
}
