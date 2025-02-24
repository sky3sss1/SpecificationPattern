namespace Domain.Entities;

public class Status : Entity
{
    public Status(string name, bool isDeleted)
    {
        Name = name;
        IsDeleted = isDeleted;
    }

    public string Name { get; set; }
    public bool IsDeleted { get; set; }
}
