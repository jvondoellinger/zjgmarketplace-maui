using zjgmarketplace.Products.Core.Entity;

namespace zjgmarketplace.Products.Infrastructure.Query.Tests;

internal class ProductMemoryRepositoryTest 
{
    public static List<Product> Products { get; } = FakeProductsLoad();

    private static List<Product> FakeProductsLoad()
    {
        var list = new List<Product>();
        var item = new Product(
                    Guid.NewGuid(),
                    "Monitor Gamer SuperFrame Prisma V2 — SFPFW‑27185‑QHD‑PRO ",
                    Guid.NewGuid().ToString(),
                    decimal.Parse("123.11"),
                    "Eletronicos",
                    ["fallback.png", "fallback.png", "fallback.png", "fallback.png"]);
        for (int i = 0; i < 50; i++)
        {
            list.Add(item);
        }
        return list;
    }
}
