#nullable disable
namespace MMORPG.Entities;

public class Item
{

    public virtual int Id { get; set; }

    public virtual string Name { get; set; }

    public virtual double BonusPoints { get; set; }

    public virtual string Description { get; set; }

    public virtual double Price { get; set; }

    public virtual double ExpNeeded { get; set; }

    public virtual char Weapon { get; set; }

    public virtual string? WeaponType { get; set; }

    public virtual double? AttackPoints { get; set; }

    public virtual char Armour { get; set; }

    public virtual double? DefensePoints { get; set; }

    public virtual IList<Owns> OwnedByPlayers { get; set; }

    public virtual IList<AllowedRace> AllowedRaces { get; set; }

    public virtual IList<AllowedClass> AllowedClasses { get; set; }

    public Item()
    {
        OwnedByPlayers = new List<Owns>();
        AllowedRaces = new List<AllowedRace>();
        AllowedClasses = new List<AllowedClass>();
    }

}