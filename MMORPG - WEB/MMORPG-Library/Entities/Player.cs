#nullable disable

namespace MMORPG.Entities;

public class Player
{
    public virtual int Id { get; protected set; }

    public virtual string Nickname { get; set; }

    public virtual string Password { get; set; }

    public virtual string Name { get; set; }

    public virtual string Surname { get; set; }

    public virtual string Gender { get; set; }

    public virtual int Age { get; set; }

    public virtual IList<Character> Characters { get; set; }

    public virtual IList<Session> Sessions { get; set; }

    public virtual Team Team { get; set; }

    public virtual IList<Transit> Transitions { get; set; }

    public virtual IList<Owns> OwnsItems { get; set; }

    public Player()
    {
        Sessions = new List<Session>();
        Transitions = new List<Transit>();
        Characters = new List<Character>();
        OwnsItems = new List<Owns>();
    }
}
