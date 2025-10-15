using Marketplace.Products.Core.Model;
using System.IO;
using System.Reflection.Metadata;

namespace Marketplace.Products.Core.Requests;

public interface IQueryProductImageRequest
{
    Task<List<byte[]>> QueryImages(string path);
    Task<byte[]> QueryFirstImage(IEnumerable<string> paths);
}
