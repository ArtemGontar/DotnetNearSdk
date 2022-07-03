using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Network;

public class GetValidationStatusResult
{
    [JsonPropertyName("current_validators")]
    public IEnumerable<Validatior> CurrentValidators { get; set; }
    
    [JsonPropertyName("next_validators")]
    public IEnumerable<Validatior> NextValidators { get; set; }
    
    [JsonPropertyName("current_fishermen")]
    public IEnumerable<Fisherman> CurrentFishermen { get; set; }
    
    [JsonPropertyName("next_fishermen")]
    public IEnumerable<Fisherman> NextFishermen { get; set; }
    
    [JsonPropertyName("current_proposals")]
    public IEnumerable<Fisherman> CurrentProposals { get; set; }
    
    [JsonPropertyName("prev_epoch_kickout")]
    public object[] PrevEpochKickout { get; set; }
    
    [JsonPropertyName("epoch_start_height")]
    public ulong EpochStartHeight { get; set; }
    
    [JsonPropertyName("epoch_height")]
    public uint EpochHeight { get; set; }
}

public class Validatior
{
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }
    [JsonPropertyName("public_key")]
    public string PublicKey { get; set; }
    [JsonPropertyName("is_slashed")]
    public bool IsSlashed { get; set; }
    [JsonPropertyName("stake")]
    public string Stake { get; set; }
    [JsonPropertyName("shards")]
    public IEnumerable<int> Shards { get; set; }
    [JsonPropertyName("num_produced_blocks")]
    public uint NumProducedBlocks { get; set; }
    [JsonPropertyName("num_expected_blocks")]
    public uint NumExpectedBlocks { get; set; }
}

public class Fisherman
{
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }
    [JsonPropertyName("public_key")]
    public string PublicKey { get; set; }
    [JsonPropertyName("stake")]
    public string Stake { get; set; }
}