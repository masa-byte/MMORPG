#nullable disable
namespace MMORPG.Entities;

public class Session
{
    public virtual int Id { get; protected set; }

    public virtual DateTime StartTime { get; set; }

    public virtual DateTime EndTime { get; set; }

    public virtual double Points { get; set; }

    public virtual double Gold { get; set; }

    public virtual Player Player { get; set; }

}
