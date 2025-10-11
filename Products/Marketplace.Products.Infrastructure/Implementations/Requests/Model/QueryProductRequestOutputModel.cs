using Marketplace.SharedLayer.Services.Serializers;
using System.Text.Json.Serialization;

namespace Marketplace.Products.Infrastructure.Implementations.Requests.Model;

public class QueryProductRequestOutputModel
{
    public string Id { get; set; } 

    public string Title { get; init; }
    public string Description { get; init; }
    public decimal Amount { get; init; }
    public ImagePathList? Paths { get; init; }
/*
    [JsonConverter(typeof(UnixMillisecondsToDateTimeConverter))]
    public DateTime CreatedAt { get; set; }
    [JsonConverter(typeof(UnixMillisecondsToDateTimeConverter))]
    public DateTime UpdatedAt { get; set; }*/
}

public class ImagePath
{
    public string CompletePath { get; init; }
}
public class ImagePathList
{
    public List<ImagePath> Paths { get; init; }
}
