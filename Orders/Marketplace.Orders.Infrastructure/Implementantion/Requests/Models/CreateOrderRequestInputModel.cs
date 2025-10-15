namespace Marketplace.Orders.Infrastructure.Implementantion.Requests.Models;

public record CreateOrderRequestInputModel(List<string> ProductId,
                             string State,
                             decimal Amount)
{ }
