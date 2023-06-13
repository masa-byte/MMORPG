#nullable disable
namespace MMORPG.Entities;

public class AllowedClass
{

    public virtual int Id { get; set; }

    public virtual string ClassName { get; set; }

    public virtual Item Item { get; set; }

}
