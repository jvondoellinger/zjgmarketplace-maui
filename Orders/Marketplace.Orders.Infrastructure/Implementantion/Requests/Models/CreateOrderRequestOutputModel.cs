namespace Marketplace.Orders.Infrastructure.Implementantion.Requests.Models;

public record CreateOrderRequestOutputModel(List<string> ProductId,
                             string State,
                             decimal Amount)
{ }

