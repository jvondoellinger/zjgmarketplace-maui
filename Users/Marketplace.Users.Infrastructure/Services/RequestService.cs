using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace Marketplace.Users.Infrastructure.Services;

internal static class RequestService
{
    private static void AddHeaders(HttpClient client, string authToken = null, Dictionary<string, string> headers = null)
    {
        if (headers != null)
            foreach (var pair in headers)
                client.DefaultRequestHeaders.Add(pair.Key, pair.Value);

        if (authToken != null)
            client.DefaultRequestHeaders.Add("Authorization", authToken);
    }

    internal static async Task<T?> PostAsync<T>(string url, object obj, string authToken = null, Dictionary<string, string> headers = null)
    {
        using var client = new HttpClient();
        AddHeaders(client, authToken, headers);
        var response = await client.PostAsJsonAsync(url, obj);
        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(json);
    }

    internal static async Task<T?> GetAsync<T>(string url, string authToken = null, Dictionary<string, string> headers = null)
    {
        using var client = new HttpClient();
        AddHeaders(client, authToken, headers);
        var response = await client.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(json);
    }
}
