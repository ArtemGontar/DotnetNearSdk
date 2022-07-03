using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Block;

public class GetBlockDetailsResult
{
    [JsonPropertyName("author")]
    public string Author { get; set; }
    
    [JsonPropertyName("header")]
    public BlockHeader Header { get; set; }
    
    [JsonPropertyName("chunks")] 
    public IEnumerable<Chunk> Chunks { get; set; } = new List<Chunk>();
}

public class BlockHeader
{
    [JsonPropertyName("height")]
    public uint Height { get; set; }

    [JsonPropertyName("epoch_id")]
    public string EpochId { get; set; }
    
    [JsonPropertyName("next_epoch_id")]
    public string NextEpochId { get; set; }

    [JsonPropertyName("hash")]
    public string Hash { get; set; }

    [JsonPropertyName("prev_hash")]
    public string PrevHash { get; set; }

    [JsonPropertyName("prev_state_root")]
    public string PrevStateRoot { get; set; }

    [JsonPropertyName("chunk_receipts_root")]
    public string ChunkReceiptsRoot { get; set; }

    [JsonPropertyName("chunk_headers_root")]
    public string ChunkHeadersRoot { get; set; }

    [JsonPropertyName("chunk_tx_root")]
    public string ChunkTxRoot { get; set; }

    [JsonPropertyName("outcome_root")]
    public string OutcomeRoot { get; set; }

    [JsonPropertyName("chunks_included")]
    public uint ChunksIncluded { get; set; }

    [JsonPropertyName("challenges_root")]
    public string ChallengesRoot { get; set; }
    
    [JsonPropertyName("timestamp")]
    public ulong NumericTimestamp { get; set; }
    
    [JsonPropertyName("timestamp_nanosec")]
    public string TimestampNanosec { get; set; }

    [JsonPropertyName("random_value")]
    public string RandomValue { get; set; }

    [JsonPropertyName("validator_proposals")]
    public IEnumerable<object> ValidatorProposals { get; set; } = new List<object>();

    [JsonPropertyName("chunk_mask")] 
    public IEnumerable<bool> ChunkMask { get; set; } = new List<bool>();

    [JsonPropertyName("gas_price")]
    public string GasPrice { get; set; }

    [JsonPropertyName("rent_paid")]
    public string RentPaid { get; set; }

    [JsonPropertyName("validator_reward")]
    public string ValidatorReward { get; set; }

    [JsonPropertyName("total_supply")]
    public string TotalSupply { get; set; }

    [JsonPropertyName("challenges_result")]
    public IEnumerable<object> ChallengesResult { get; set; } = new List<object>();

    [JsonPropertyName("last_final_block")]
    public string LastFinalBlock { get; set; }
    
    [JsonPropertyName("last_ds_final_block")]
    public string LastDsFinalBlock { get; set; }

    [JsonPropertyName("next_bp_hash")]
    public string NextBpHash { get; set; }

    [JsonPropertyName("block_merkle_root")]
    public string BlockMerkleRoot { get; set; }

    [JsonPropertyName("approvals")] 
    public IEnumerable<string> Approvals { get; set; } = new List<string>();
    
    [JsonPropertyName("signature")]
    public string Signature { get; set; }
    
    [JsonPropertyName("latest_protocol_version")]
    public uint LatestProtocolVersion { get; set; }
}

public class Chunk
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
    public ulong GasUsed { get; set; }

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
    public string TxToot { get; set; }

    [JsonPropertyName("validator_proposals")]
    public IEnumerable<object> ValidatorProposals { get; set; } = new List<object>();
    
    [JsonPropertyName("signature")]
    public string Signature { get; set; }
}