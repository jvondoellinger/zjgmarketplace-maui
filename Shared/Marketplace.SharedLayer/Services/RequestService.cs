using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json;

namespace Marketplace.SharedLayer.Services;

public class RequestService
{
    private readonly JsonSerializerOptions serializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    private readonly HttpClient client;

    public RequestService(HttpClient client)
    {
        this.client = client;
    }

    public async Task<T?> PostAsync<T>(Uri url, object obj, Dictionary<string, string>? headers = null)
    {
        var response = await client.PostAsJsonAsync(url, obj, serializerOptions);
        var jsonTask = response.Content.ReadAsStringAsync(); // Task running

        if (!response.IsSuccessStatusCode)
            throw new Exception($"POST failed. Message: {response.ReasonPhrase}");
        var json = await jsonTask;
        return JsonSerializer.Deserialize<T>(json, serializerOptions);
    }

    public async Task<T?> GetAsync<T>(Uri url, Dictionary<string, string> headers = null)
    {
        try
        {
            var response = await client.GetAsync(url);
            var jsonTask = response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
                Debug.WriteLine($"Get failed. Erro: {response.ReasonPhrase}");
            var json = await jsonTask;
            return JsonSerializer.Deserialize<T>(json, serializerOptions);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            throw;
        }
    }
}
