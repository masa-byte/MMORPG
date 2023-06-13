#nullable disable

namespace MMORPG.Entities;

public class Transit
{
    public virtual int Id { get; protected set; }
    public virtual int EnemiesDefeated { get; set;}
    public virtual char Successful { get; set;}
    public virtual Track Track { get; set;}
    public virtual Player Player { get; set;}
    public virtual Team Team { get; set;}
}
