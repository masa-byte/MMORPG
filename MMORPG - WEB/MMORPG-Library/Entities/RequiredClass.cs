#nullable disable
namespace MMORPG.Entities;

public class RequiredClass
{
    public virtual int Id { get; set; }

    public virtual string ClassName { get; set; }

    public virtual Track Track { get; set; }
}
