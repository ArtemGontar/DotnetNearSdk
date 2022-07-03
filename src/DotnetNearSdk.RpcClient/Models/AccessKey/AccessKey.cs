using System.Text.Json.Serialization;

namespace BlockMetrics.NearRPC.Models.AccessKey;

public class AccessKey
{
    [JsonPropertyName("nonce")]
    public uint Nonce { get; set; }
    
    [JsonPropertyName("permission")]
    public object Permission { get; set; }
}