namespace Domain.Specifications;

public class GetNewOrdersWithOrderItemsSpecification : BaseSpecification<Order>
{
    public GetNewOrdersWithOrderItemsSpecification() : base(c => c.StatusId == Statuses.New)
    {
        AddInclude(c => c.OrderItems);
    }
}
