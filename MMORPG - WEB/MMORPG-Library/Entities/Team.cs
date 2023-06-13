#nullable disable
namespace MMORPG.Entities;

public class Team
{

    public virtual int Id { get; set; }

    public virtual string Name { get; set; }

    public virtual int MaxPlayers { get; set; }

    public virtual int MinPlayers { get; set; }

    public virtual double BonusPoints { get; set; }

    public virtual double Placement { get; set; }

    public virtual IList<Player> Players { get; set; }

    public virtual IList<Transit> Transitions { get; set; }
    public virtual IList<Fights> Teams1 { get; set; }
    public virtual IList<Fights> Teams2 { get; set; }

    public Team()
    {
        Players = new List<Player>();
        Transitions = new List<Transit>();
        Teams1 = new List<Fights>();
        Teams2 = new List<Fights>();
    }

}
