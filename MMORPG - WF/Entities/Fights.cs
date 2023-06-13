#nullable disable

namespace MMORPG.Entities;

public class Fights
{
    public virtual int Id { get; protected set; }
    public virtual double Bonus { get; set;}
    public virtual DateTime TimeHeld { get; set;}
    public virtual int? WinningTeam { get; set;}
    public virtual Team Team1 { get; set;}
    public virtual Team Team2 { get; set; }
}
