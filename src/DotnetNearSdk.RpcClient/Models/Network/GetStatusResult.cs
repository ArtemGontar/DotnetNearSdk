using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Network;

public class GetStatusResult
{
    [JsonPropertyName("version")]
    public RpcVersion Version { get; set; }
    
    [JsonPropertyName("chain_id")]
    public string ChainId { get; set; }
    
    [JsonPropertyName("protocol_version")]
    public uint ProtocolVersion { get; set; }
    
    [JsonPropertyName("latest_protocol_version")]
    public uint LatestProtocolVersion { get; set; }
    
    [JsonPropertyName("rpc_addr")]
    public string RpcAddr { get; set; }
    
    [JsonPropertyName("sync_info")]
    public SyncInfo SyncInfo { get; set; }
    
    [JsonPropertyName("validators")]
    public IEnumerable<Validator> Validators { get; set; } = new List<Validator>();

}

public class RpcVersion
{
    [JsonPropertyName("version")]
    public string Version { get; set; }
    
    [JsonPropertyName("build")]
    public string Build { get; set; }
}

public class Validator
{
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }
    
    [JsonPropertyName("is_slashed")]
    public bool IsSlashed { get; set; }
}

public class SyncInfo
{
    [JsonPropertyName("latest_block_hash")]
    public string LatestBlockHash { get; set; }
    
    [JsonPropertyName("latest_block_height")]
    public uint LatestBlockHeight { get; set; }
    
    [JsonPropertyName("latest_state_root")]
    public string LatestStateRoot { get; set; }
    
    [JsonPropertyName("latest_block_time")]
    public string LatestBlockTime { get; set; }
    
    [JsonPropertyName("syncing")]
    public bool Syncing { get; set; }
}