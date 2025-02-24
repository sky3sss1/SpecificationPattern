namespace Domain.Entities;

public class User : Entity
{
    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public string Name { get; set; }
    public string Email { get; set; }

    #region vurtuals
    public virtual ICollection<Order> Orders { get; set; } = [];
    #endregion
}
