namespace Domain.BaseEntities;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreateData { get; set; } = DateTime.UtcNow;
    public DateTime UpdateData { get; set; } = DateTime.UtcNow;
}
