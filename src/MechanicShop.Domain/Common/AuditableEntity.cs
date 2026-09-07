namespace MechanicShop.Domain.Common;

public abstract class AuditableEntity : Entity
{
    public DateTimeOffset CreatedAtUtc { get; set; }
    public string CreatedBy { get; set; } = string.Empty;

    public DateTimeOffset? LastModifiedUtc { get; set; }
    public string LastModifiedBy { get; set; } = string.Empty;

    protected AuditableEntity() { }
    protected AuditableEntity(Guid id) : base(id) { }
}