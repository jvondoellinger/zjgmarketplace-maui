namespace Marketplace.Products.Infrastructure.Implementations.Requests.Commands.Models;

public record CreateOrderRequestOutputModel(List<string> ProductId,
                             string State,
                             decimal Amount)
{}
