namespace DemoGeneric2.Interfaces;

public interface IBaseEntity
{
    Guid Id { get; }
    DateTime CreatedAt { get; }
    DateTime LastUpdatedAt { get; }
}
