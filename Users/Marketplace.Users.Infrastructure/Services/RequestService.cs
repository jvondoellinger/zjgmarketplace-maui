using System.Diagnostics;
using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace Marketplace.Users.Infrastructure.Services;

internal static class RequestService
{
    private static JsonSerializerOptions serializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    private static void AddHeaders(HttpClient client, string authToken = null, Dictionary<string, string> headers = null)
    {
        if (headers != null)
            foreach (var pair in headers)
                client.DefaultRequestHeaders.Add(pair.Key, pair.Value);

        if (authToken != null)
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
    }

    internal static async Task<T?> PostAsync<T>(string url, object obj, string authToken = null, Dictionary<string, string> headers = null)
    {
        using var client = new HttpClient();
        AddHeaders(client, authToken, headers);

        Test(obj);

        var response = await client.PostAsJsonAsync(url, obj, serializerOptions);

        if (!response.IsSuccessStatusCode)
            throw new Exception($"POST failed. Message: {response.ReasonPhrase}");

        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(json, serializerOptions);
    }

    internal static async Task<T?> GetAsync<T>(string url, string authToken = null, Dictionary<string, string> headers = null)
    {
        using var client = new HttpClient();
        AddHeaders(client, authToken, headers);

        var response = await client.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        
        return JsonSerializer.Deserialize<T>(json, serializerOptions);
    }

    private static void Test(object obj)
    {
        var json= JsonSerializer.Serialize(obj, serializerOptions);
        Debug.WriteLine(json);
    }
}
