namespace Marketplace.Orders.Infrastructure.Implementantion.Requests.Models;

public record CreateOrderRequestInputModel(List<int> ProductId,
                             string State,
                             decimal Amount)
{ }
