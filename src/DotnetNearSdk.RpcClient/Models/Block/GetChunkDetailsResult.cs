using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Block;

public class GetChunkDetailsResult
{
    [JsonPropertyName("author")]
    public string Author { get; set; }
    
    [JsonPropertyName("header")]
    public ChunkHeader Header { get; set; }

    [JsonPropertyName("transactions")] 
    public IEnumerable<object> Transactions { get; set; } = new List<object>();

    [JsonPropertyName("receipts")] 
    public IEnumerable<object> Receipts { get; set; } = new List<object>();
}

public class ChunkHeader
{
    [JsonPropertyName("chunk_hash")]
    public string ChunkHash { get; set; }

    [JsonPropertyName("prev_block_hash")]
    public string PrevBlockHash { get; set; }
    
    [JsonPropertyName("outcome_root")]
    public string OutcomeRoot { get; set; }

    [JsonPropertyName("prev_state_root")]
    public string PrevStateRoot { get; set; }

    [JsonPropertyName("encoded_merkle_root")]
    public string EncodedMerkleRoot { get; set; }

    [JsonPropertyName("encoded_length")]
    public uint EncodedLength { get; set; }

    [JsonPropertyName("height_created")]
    public uint HeightCreated { get; set; }

    [JsonPropertyName("height_included")]
    public uint HeightIncluded { get; set; }

    [JsonPropertyName("shard_id")]
    public uint ShardId { get; set; }

    [JsonPropertyName("gas_used")]
    public uint GasUsed { get; set; }

    [JsonPropertyName("gas_limit")]
    public ulong GasLimit { get; set; }

    [JsonPropertyName("rent_paid")]
    public string RentPaid { get; set; }
    
    [JsonPropertyName("validator_reward")]
    public string ValidatorReward { get; set; }
    
    [JsonPropertyName("balance_burnt")]
    public string BalanceBurnt { get; set; }

    [JsonPropertyName("outgoing_receipts_root")]
    public string OutgoingReceiptsRoot { get; set; }

    [JsonPropertyName("tx_root")]
    public string TxRoot { get; set; }

    [JsonPropertyName("validator_proposals")] 
    public IEnumerable<object> ValidatorProposals { get; set; } = new List<object>();

    [JsonPropertyName("signature")]
    public string Signature { get; set; }
}
