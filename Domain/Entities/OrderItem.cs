namespace Domain.Entities;

public class OrderItem : Entity
{
    public OrderItem(int rowNumber, Guid orderId)
    {
        RowNumber = rowNumber;
        OrderId = orderId;
    }

    public int RowNumber { get; set; }
    public Guid OrderId { get; set; }

    #region virtuals
    public Order Order { get; set; } = null!;
    #endregion
}
