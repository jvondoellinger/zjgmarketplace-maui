using Marketplace.Products.Core.Model;
using System.IO;
using System.Reflection.Metadata;

namespace Marketplace.Products.Core.Requests;

public interface IQueryProductImageRequest
{
    Task<List<byte[]>> QueryImages(IEnumerable<string> paths);
    Task<byte[]> QueryFirstImage(string path);
}
