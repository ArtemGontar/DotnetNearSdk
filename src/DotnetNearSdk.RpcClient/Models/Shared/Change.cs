using System.Text.Json.Serialization;

namespace BlockMetrics.NearRPC.Models.Shared;

public class Change<TChange>
{
    [JsonPropertyName("cause")]
    public Cause Cause { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    [JsonPropertyName("change")]
    public TChange ChangeInternal { get; set; }
}

public class Cause
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    [JsonPropertyName("tx_hash")]
    public string TxHash { get; set; }
}
