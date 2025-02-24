
namespace Application.Features.Orders.Commands;

public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddOrderCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }

    public async Task Handle(AddOrderCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.OrderItems.AddRangeAsync(request.OrderItems.ToArray());
        await _unitOfWork.Orders.AddAsync(request.Order);
        await _unitOfWork.SaveChangesAsync();
    }
}
