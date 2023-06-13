#nullable disable
using MMORPG.Entities;

namespace MMORPG
{

    public class SaveCharacterView
    {
        public int Id { get; set; }

        public double FatigueLevel { get; set; }

        public double HealthLevel { get; set; }

        public double Experience { get; set; }

        public double Gold { get; set; }

        public string Race { get; set; }

        public double? EnergyLevel { get; set; }

        public string? WeaponType { get; set; }

        public double? HidingSkill { get; set; }

        public char Assistant { get; set; }

        public string AssistantName { get; set; }

        public double? AssistantBonus { get; set; }

        public SaveCharacterView() { }
    }

    public class SaveThiefView : SaveCharacterView
    {
        public double NoiseLevel { get; set; }

        public char TrapRemoval { get; set; }

        public SaveThiefView() { }
    }

    public class SaveFighterView : SaveCharacterView
    {
        public char Shield { get; set; }
        public char TwohandedWeapon { get; set; }

        public SaveFighterView() { }
    }

    public class SaveWizardView : SaveCharacterView
    {
        public SaveWizardView() { }
    }

    public class SaveArcherView : SaveCharacterView
    {
        public string BowCrossbow { get; set; }

        public SaveArcherView() { }
    }

    public class SaveDefenderView : SaveCharacterView
    {
        public double MaxArmourWeight { get; set; }

        public SaveDefenderView() { }
    }

    public class SavePriestView : SaveCharacterView
    {
        public string Religion { get; set; }
        public char Heals { get; set; }
    }

    public class CompactTeamView
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int MaxPlayers { get; set; }

        public int MinPlayers { get; set; }

        public double BonusPoints { get; set; }

        public CompactTeamView() { }

        public CompactTeamView(string name, double bonusPoints)
        {
            Name = name;
            BonusPoints = bonusPoints;
        }
    }

    public class PlayerView
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public double? TotalPoints { get; set; }

        public PlayerView() { }

        public PlayerView(int id, string nickname, string name, string surname, string gender, int age, double totalPoints)
        {
            Id = id;
            Nickname = nickname;
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
            TotalPoints = totalPoints;
        }
    }

    public class TeamView
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual int MaxPlayers { get; set; }

        public virtual int MinPlayers { get; set; }

        public double BonusPoints { get; set; }

        public double Placement { get; set; }

        public int PlayerCount { get; set; }

        public IList<Player> Players { get; set; }

        public TeamView() { }

        public TeamView(int id, string name, double bonusPoints, double placement, IList<Player> players)
        {
            Id = id;
            Name = name;
            BonusPoints = bonusPoints;
            Placement = placement;
            Players = players;
            PlayerCount = players.Count;
        }
    }

    public class BlessingView
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public BlessingView() { }

        public BlessingView(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class AllowedRaceView
    {
        public string RaceName { get; set; }

        public AllowedRaceView() { }

        public AllowedRaceView(string raceName)
        {
            RaceName = raceName;
        }
    }

    public class AllowedClassView
    {
        public string ClassName { get; set; }

        public AllowedClassView() { }

        public AllowedClassView(string className)
        {
            ClassName = className;
        }
    }

    public class ItemView
    {

        public int Id { get; set; }

        public string? Name { get; set; }

        public double? BonusPoints { get; set; }

        public string? Description { get; set; }

        public double? Price { get; set; }

        public double? ExpNeeded { get; set; }

        public char? Weapon { get; set; }

        public string? WeaponType { get; set; }

        public double? AttackPoints { get; set; }

        public char? Armour { get; set; }

        public double? DefensePoints { get; set; }

        // allowed races and classes can be excluded

        public List<AllowedRaceView> AllowedRaces { get; set; }

        public List<AllowedClassView> AllowedClasses { get; set; }

        public ItemView() { }

        public ItemView(
            int id, string name, double bonusPoints, string description,
            double price, double expNeeded, char weapon, string weaponType,
            double? attackPoints, char armour, double? defensePoints,
            List<AllowedRaceView> allowedRaces = null, List<AllowedClassView> allowedClasses = null)
        {
            Id = id;
            Name = name;
            BonusPoints = bonusPoints;
            Description = description;
            Price = price;
            ExpNeeded = expNeeded;
            Weapon = weapon;
            WeaponType = weaponType;
            AttackPoints = attackPoints;
            Armour = armour;
            DefensePoints = defensePoints;
            AllowedRaces = allowedRaces ?? new();
            AllowedClasses = allowedClasses ?? new();
        }

    }

    public class RequiredClassView
    {
        public string ClassName { get; set; }
        public RequiredClassView() { }
        public RequiredClassView(string className)
        {
            ClassName = className;
        }
    }

    public class RequiredRaceView
    {
        public string RaceName { get; set; }
        public RequiredRaceView() { }
        public RequiredRaceView(string raceName)
        {
            RaceName = raceName;
        }
    }

    public class TrackView
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public char? Team { get; set; }
        public double? Bonus { get; set; }
        public List<RequiredRaceView>? RequiredRaces { get; set; }
        public List<RequiredClassView>? RequiredClasses { get; set; }

        public TrackView() { }

        public TrackView(
            int id, string name, char team, double bonus,
            List<RequiredRaceView> requiredRaces = null,
            List<RequiredClassView> requiredClasses = null)
        {
            Id = id;
            Name = name;
            Team = team;
            Bonus = bonus;
            RequiredRaces = requiredRaces ?? new();
            RequiredClasses = requiredClasses ?? new();
        }
    }

    public class SpellView
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SpellView() { }

        public SpellView(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class CharacterView
    {
        public int Id { get; set; }

        public string ClassName { get; set; }

        public string RaceName { get; set; }

        public double Gold { get; set; }

        public double Exp { get; set; }

        public CharacterView() { }

        public CharacterView(int id, string className, string raceName, double gold, double exp)
        {
            Id = id;
            ClassName = className;
            RaceName = raceName;
            Gold = gold;
            Exp = exp;
        }
    }

    public class FightsView
    {
        public int Id { get; protected set; }
        public double Bonus { get; set; }
        public DateTime TimeHeld { get; set; }
        public int? WinningTeam { get; set; }
        public CompactTeamView Team1 { get; set; }
        public CompactTeamView Team2 { get; set; }

        public FightsView() { }

        public FightsView(int id, double bonus, DateTime timeHeld, int? winningTeam, CompactTeamView team1, CompactTeamView team2)
        {
            Id = id;
            Bonus = bonus;
            TimeHeld = timeHeld;
            WinningTeam = winningTeam;
            Team1 = team1;
            Team2 = team2;
        }
    }

    public class CreateCharacterView
    {
        public virtual int Id { get; set; }

        public virtual double FatigueLevel { get; set; }

        public virtual double HealthLevel { get; set; }

        public virtual double Experience { get; set; }

        public virtual double Gold { get; set; }

        public virtual string Race { get; set; }

        public virtual double? EnergyLevel { get; set; }

        public virtual string? WeaponType { get; set; }

        public virtual double? HidingSkill { get; set; }

        public virtual char Assistant { get; set; }

        public virtual string AssistantName { get; set; }

        public virtual double? AssistantBonus { get; set; }

        public CreateCharacterView() { }
    }
}
