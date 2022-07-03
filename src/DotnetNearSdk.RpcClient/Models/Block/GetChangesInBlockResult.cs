using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Block;

public class GetChangesInBlockResult
{
    [JsonPropertyName("block_hash")]
    public string BlockHash { get; set; }

    [JsonPropertyName("changes")] 
    public IEnumerable<Change> Changes { get; set; } = new List<Change>();
}

public class Change
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("account_id")] 
    public string AccountId { get; set; }
}