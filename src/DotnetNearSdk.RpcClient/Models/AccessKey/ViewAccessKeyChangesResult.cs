using System.Text.Json.Serialization;
using DotnetNearSdk.NearRPC.Models.Shared;

namespace DotnetNearSdk.NearRPC.Models.AccessKey;

public class ViewAccessKeyChangesResult
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
    
    [JsonPropertyName("public_key")]
    public string PublicKey { get; set; }
    
    [JsonPropertyName("access_key")]
    public AccessKey AccessKey { get; set; }
}