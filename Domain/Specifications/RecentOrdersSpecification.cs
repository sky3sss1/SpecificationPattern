namespace Domain.Specifications;

public class RecentOrdersSpecification : BaseSpecification<Order>
{
    public RecentOrdersSpecification() : base(c => c.CreateData >= DateTime.UtcNow.AddDays(-7)) { }
}
