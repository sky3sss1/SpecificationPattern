using Application.Features.Orders.Commands;
using Domain.Entities;

namespace Web.API.Models;

public class AddOrderAndOrderItemsModel
{
    public AddOrderAndOrderItemsModel(int orderNumber, Guid userId, Guid statusId)
    {
        OrderNumber = orderNumber;
        UserId = userId;
        StatusId = statusId;
    }

    public int OrderNumber { get; set; }
    public Guid UserId { get; set; }
    public Guid StatusId { get; set; }

    public AddOrderCommand ToCommand()
    {

        return new AddOrderCommand(new Order(OrderNumber, UserId, StatusId));
    }
}
