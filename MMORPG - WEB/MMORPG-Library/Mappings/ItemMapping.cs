using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class ItemMapping : ClassMap<Item>
{

    public ItemMapping()
    {
        Table("ITEM");

        Id(item => item.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(item => item.Name, "NAME");
        Map(item => item.BonusPoints, "BONUS_POINTS").Scale(2);
        Map(item => item.Description, "DESCRIPTION");
        Map(item => item.Price, "PRICE").Scale(2);
        Map(item => item.ExpNeeded, "EXP_NEEDED").Scale(2);
        Map(item => item.Weapon, "F_WEAPON");
        Map(item => item.WeaponType, "WEAPON_TYPE");
        Map(item => item.AttackPoints, "ATTACK_POINTS").Scale(2);
        Map(item => item.Armour, "F_ARMOUR");
        Map(item => item.DefensePoints, "DEFENSE_POINTS").Scale(2);

        HasMany(item => item.OwnedByPlayers).KeyColumn("ITEM_ID").Cascade.All().Inverse().LazyLoad();
        HasMany(item => item.AllowedRaces).KeyColumn("ITEM_ID").Cascade.AllDeleteOrphan().LazyLoad();
        HasMany(item => item.AllowedClasses).KeyColumn("ITEM_ID").Cascade.AllDeleteOrphan().LazyLoad();
    }

}
