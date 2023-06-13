#nullable disable
namespace MMORPG.Entities;

public class Track
{
    public virtual int Id { get; protected set; }
    public virtual string Name { get; set;}
    public virtual char Team { get; set; }
    public virtual double Bonus { get; set; }
    public virtual IList<Transit> Transitions { get; set; }
    public virtual IList<RequiredRace> RequiredRaces { get; set; }
    public virtual IList<RequiredClass> RequiredClasses { get; set; }

    public Track()
    {
        Transitions = new List<Transit>();
        RequiredRaces = new List<RequiredRace>();
        RequiredClasses = new List<RequiredClass>();
    }

}
