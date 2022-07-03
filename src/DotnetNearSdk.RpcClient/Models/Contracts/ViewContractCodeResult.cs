using System.Text.Json.Serialization;

namespace BlockMetrics.NearRPC.Models.Contracts;

public class ViewContractCodeResult
{
    [JsonPropertyName("code_base64")]
    public string CodeBase64 { get; set; }

    [JsonPropertyName("hash")] 
    public string Hash { get; set; }
    
    [JsonPropertyName("block_height")]
    public uint BlockHeight { get; set; }

    [JsonPropertyName("block_hash")] 
    public string BlockHash { get; set; }
    
}