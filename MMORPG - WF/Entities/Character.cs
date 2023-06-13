#nullable disable

namespace MMORPG.Entities;

public abstract class Character
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

    public virtual Player Player { get; set; }
}