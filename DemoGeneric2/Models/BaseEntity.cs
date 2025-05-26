using DemoGeneric2.Interfaces;

namespace DemoGeneric2.Models;

public abstract class BaseEntity : IBaseEntity
{

    public BaseEntity()
    {
        CreatedAt = DateTime.Now;
    }


    public Guid Id { get; set; }

    public DateTime CreatedAt { get; init; }

    public DateTime LastUpdatedAt { get; set; }
}
