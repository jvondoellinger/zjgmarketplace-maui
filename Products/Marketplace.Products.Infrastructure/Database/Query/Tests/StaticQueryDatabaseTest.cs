using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Query;

namespace Marketplace.Products.Infrastructure.Database.Query.Tests;

public class StaticQueryDatabaseTest : IProductQuery
{
    private static readonly string randomURL = "https://www.valuehost.com.br/blog/wp-content/uploads/2023/07/valuesoftsistemas_valuehosthospedagem_image_737.jpeg.webp";
    private static List<Product> Products { get; } = FakeProductsLoad();

    private static List<Product> FakeProductsLoad()
    {
        var list = new List<Product>();

        for (int i = 0; i < 50; i++)
        {
            var id = Guid.NewGuid().ToString();
            var item = new Product(
                Guid.NewGuid().ToString(),
                "Monitor Gamer SuperFrame Prisma V2 — SFPFW‑27185‑QHD‑PRO ",
                id+id+id+id+id+id,
                369.33m,
                "Eletronicos",
                []);
            list.Add(item);
        }
        return list;
    }

    public async Task<Product?> Find(int id)
    {
        return Products.Find(p => p.Id.Equals(id));
    }

#pragma warning disable CS1998 
    public async Task<List<Product>> QueryPagination(int offset, int limit)
#pragma warning restore CS1998 
    {
        return [.. Products
            .Skip(offset)
            .Take(limit)];
    }
}
