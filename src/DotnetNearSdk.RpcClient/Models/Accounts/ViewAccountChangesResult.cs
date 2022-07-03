using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Accounts;

public class ViewAccountChangesResult
{
    [JsonPropertyName("amount")]
    public string Amount { get; set; }
    
    [JsonPropertyName("locked")]
    public string Locked { get; set; }
    
    [JsonPropertyName("code_hash")]
    public string CodeHash { get; set; }
    
    [JsonPropertyName("storage_usage")]
    public uint StorageUsage { get; set; }
    
    [JsonPropertyName("storage_paid_at")]
    public uint StoragePaidAt { get; set; }
    
    [JsonPropertyName("block_height")]
    public uint BlockHeight { get; set; }
    
    [JsonPropertyName("block_hash")]
    public string BlockHash { get; set; }
}