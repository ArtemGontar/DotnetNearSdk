using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Network;

public class GetNetworkInfoResult
{
    [JsonPropertyName("num_active_peers")]
    public uint NumActivePeers { get; set; }

    [JsonPropertyName("peer_max_count")]
    public uint PeerMaxCount { get; set; }

    [JsonPropertyName("sent_bytes_per_sec")]
    public ulong SentBytesPerSec { get; set; }
    
    [JsonPropertyName("received_bytes_per_sec")]
    public ulong ReceivedBytesPerSec { get; set; }

    [JsonPropertyName("known_producers")]
    public IEnumerable<KnownProducer> KnownProducers { get; set; } = new List<KnownProducer>();
    
    [JsonPropertyName("active_peers")]
    public IEnumerable<ActivePeers> ActivePeers { get; set; } = new List<ActivePeers>();
}

public class ActivePeers 
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("addr")]
    public string Addr { get; set; }
    
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }
}

public class KnownProducer
{
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }
    
    [JsonPropertyName("addr")]
    public string Addr { get; set; }
    
    [JsonPropertyName("peer_id")]
    public string PeerId { get; set; }
}