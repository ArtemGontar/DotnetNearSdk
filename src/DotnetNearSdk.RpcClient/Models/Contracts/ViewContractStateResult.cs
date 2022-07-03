using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Contracts;

public class ViewContractStateResult
{
    [JsonPropertyName("values")]
    public IEnumerable<Value> Values { get; set; }

    [JsonPropertyName("proof")] 
    public IEnumerable<object> Proof { get; set; } = new List<object>();
    
    [JsonPropertyName("block_height")]
    public uint BlockHeight { get; set; }

    [JsonPropertyName("block_hash")] 
    public string BlockHash { get; set; }
}

public class Value
{
    [JsonPropertyName("key")] 
    public string Key { get; set; }
    
    [JsonPropertyName("value")]
    public string ValueString { get; set; }

    [JsonPropertyName("proof")] 
    public IEnumerable<object> Proof { get; set; } = new List<object>();
}