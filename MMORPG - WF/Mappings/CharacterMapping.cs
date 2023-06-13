using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class CharacterMapping : ClassMap<Character>
{

    public CharacterMapping()
    {
        Table("CHARACTER");

        Id(character => character.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(character => character.FatigueLevel, "FATIGUE_LEVEL").Scale(2);
        Map(character => character.HealthLevel, "HEALTH_LEVEL").Scale(2);
        Map(character => character.Experience, "EXPERIENCE").Scale(2);
        Map(character => character.Gold, "GOLD").Scale(2);

        Map(character => character.Race, "RACE");
        Map(character => character.EnergyLevel, "ENERGY_LEVEL").Scale(2);
        Map(character => character.WeaponType, "WEAPON_TYPE");
        Map(character => character.HidingSkill, "HIDING_SKILL").Scale(2);

        Map(character => character.Assistant, "F_ASSISTANT");
        Map(character => character.AssistantName, "NAME");
        Map(character => character.AssistantBonus, "BONUS").Scale(2);

        References(character => character.Player).Column("PLAYER_ID").LazyLoad();
    }

}