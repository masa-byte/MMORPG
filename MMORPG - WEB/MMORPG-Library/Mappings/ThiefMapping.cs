using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mappings;

public class ThiefMapping : SubclassMap<Thief>
{
    public ThiefMapping()
    {
        Table("THIEF");

        KeyColumn("CHARACTER_ID");

        Map(thief => thief.NoiseLevel).Column("NOISE_LEVEL").Scale(2);
        Map(thief => thief.TrapRemoval).Column("TRAP_REMOVAL");
    }
}
