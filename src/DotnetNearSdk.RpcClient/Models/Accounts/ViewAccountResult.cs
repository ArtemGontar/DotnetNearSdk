using System.Text.Json.Serialization;
using BlockMetrics.NearRPC.Models.Shared;

namespace BlockMetrics.NearRPC.Models.Accounts;

public class ViewAccountResult
{
    [JsonPropertyName("block_hash")]
    public string BlockHash { get; set; }

    [JsonPropertyName("changes")] 
    public IEnumerable<Change<ChangeInternal>> Changes { get; set; } = new List<Change<ChangeInternal>>();
}

public class ChangeInternal
{
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }
    
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
}