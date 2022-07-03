using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.AccessKey;

public class ViewAccessKeyListResult
{
    [JsonPropertyName("keys")] 
    public IEnumerable<Keys> Keys { get; set; } = new List<Keys>();
    
    [JsonPropertyName("block_height")]
    public uint BlockHeight { get; set; }
    
    [JsonPropertyName("block_hash")]
    public string BlockHash { get; set; }
}

public class Keys
{
    [JsonPropertyName("public_key")]
    public string PublicKey { get; set; }
    
    [JsonPropertyName("access_key")]
    public AccessKey AccessKey { get; set; }
}