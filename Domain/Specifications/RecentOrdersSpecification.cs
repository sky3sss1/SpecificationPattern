namespace Domain.Specifications;

public class RecentOrdersSpecification : BaseSpecification<Order>
{
    public RecentOrdersSpecification() : base(c => c.CreateDate >= DateTime.UtcNow.AddDays(-7)) { }
}
