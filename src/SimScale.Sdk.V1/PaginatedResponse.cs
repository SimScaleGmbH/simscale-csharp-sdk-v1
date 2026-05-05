using System.Text.Json;

namespace SimScale.Sdk.V1;

public class PaginatedResponse<T>
{
    public List<T> Embedded { get; }
    public int Total { get; }

    public PaginatedResponse(JsonElement root, JsonSerializerOptions options)
    {
        var items = new List<T>();
        if (root.TryGetProperty("_embedded", out var embedded))
        {
            foreach (var item in embedded.EnumerateArray())
            {
                items.Add(JsonSerializer.Deserialize<T>(item.GetRawText(), options)!);
            }
        }
        Embedded = items;

        Total = 0;
        if (root.TryGetProperty("_meta", out var meta) && meta.TryGetProperty("total", out var total))
        {
            Total = total.GetInt32();
        }
    }
}
