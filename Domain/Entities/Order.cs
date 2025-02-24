namespace Domain.Entities;

public class Order : Entity
{
    public Order(int orderNumber, Guid userId, Guid statusId)
    {
        OrderNumber = orderNumber;
        UserId = userId;
        StatusId = statusId;
    }

    public int OrderNumber { get; set; }
    public Guid UserId { get; set; }
    public Guid StatusId { get; set; }

    #region viruals
    public virtual User User { get; set; } = null!;
    public virtual Status Status { get; set; } = null!;
    public virtual ICollection<OrderItem> OrderItems { get; set; } = [];
    #endregion
}
