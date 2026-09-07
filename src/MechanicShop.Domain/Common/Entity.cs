namespace MechanicShop.Domain.Common;

public abstract class Entity
{
    private readonly List<DomainEvent> _domainEvents = [];
    public Guid Id { get; }

    protected Entity() : this(Guid.Empty) { }
    protected Entity(Guid id) => Id = (id == Guid.Empty) ? Guid.CreateVersion7() : id;

    public void AddDomainEvent(DomainEvent domainEvent) => _domainEvents.Add(domainEvent);
    public void RemoveDomainEvent(DomainEvent domainEvent) => _domainEvents.Remove(domainEvent);
    public void ClearDomainEvents() => _domainEvents.Clear();

}
