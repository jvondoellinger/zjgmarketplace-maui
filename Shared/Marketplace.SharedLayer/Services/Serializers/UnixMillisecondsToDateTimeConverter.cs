using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Marketplace.SharedLayer.Services.Serializers;

public class UnixMillisecondsToDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        long milliseconds = reader.GetInt64();
        return DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).UtcDateTime;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        long milliseconds = new DateTimeOffset(value).ToUnixTimeMilliseconds();
        writer.WriteNumberValue(milliseconds);
    }
}
