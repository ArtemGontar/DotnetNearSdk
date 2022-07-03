using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.AccessKey;

public class ViewAccessKeyResult
{
    [JsonPropertyName("nonce")]
    public uint Nonce { get; set; }
    
    [JsonPropertyName("permission")]
    public Permission Permission { get; set; }
    
    [JsonPropertyName("block_height")]
    public uint BlockHeight { get; set; }
    
    [JsonPropertyName("block_hash")]
    public string BlockHash { get; set; }
}

public class Permission
{
    public FunctionCall FunctionCall { get; set; }
}

public class FunctionCall
{
    [JsonPropertyName("allowance")]
    public string Allowance { get; set; }
    
    [JsonPropertyName("receiver_id")]
    public string ReceiverId { get; set; }

    [JsonPropertyName("method_names")] public IEnumerable<string> method_names { get; set; } = new List<string>();
}