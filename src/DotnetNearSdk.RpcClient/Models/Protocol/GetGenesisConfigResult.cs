using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Protocol;

public class GetGenesisConfigResult
{
    [JsonPropertyName("protocol_version")]
    public uint ProtocolVersion { get; set; }
    
    [JsonPropertyName("genesis_time")]
    public string GenesisTime { get; set; }
    
    [JsonPropertyName("chain_id")]
    public string ChainId { get; set; }
    
    [JsonPropertyName("genesis_height")]
    public uint GenesisHeight { get; set; }

    [JsonPropertyName("num_block_producer_seats")]
    public uint NumBlockProducerSeats { get; set; }

    [JsonPropertyName("num_block_producer_seats_per_shard")]
    public IEnumerable<uint> NumBlockProducerSeatsPerShard { get; set; } = new List<uint>();
    
    [JsonPropertyName("avg_hidden_validator_seats_per_shard")]
    public IEnumerable<uint> AvgHiddenValidatorSeatsPerShard { get; set; } = new List<uint>();
    
    [JsonPropertyName("dynamic_resharding")]
    public bool DynamicResharding { get; set; }

    [JsonPropertyName("protocol_upgrade_stake_threshold")]
    public IEnumerable<uint> ProtocolUpgradeStakeThreshold { get; set; } = new List<uint>();
    
    [JsonPropertyName("protocol_upgrade_num_epochs")]
    public uint ProtocolUpgradeNumEpochs { get; set; }
    
    [JsonPropertyName("epoch_length")]
    public uint EpochLength { get; set; }

    [JsonPropertyName("gas_limit")]
    public ulong GasLimit { get; set; }
    
    [JsonPropertyName("min_gas_price")]
    public string MinGasPrice { get; set; }
    
    [JsonPropertyName("max_gas_price")]
    public string MaxGasPrice { get; set; }
    
    [JsonPropertyName("block_producer_kickout_threshold")]
    public uint BlockProducerKickoutThreshold { get; set; }

    [JsonPropertyName("chunk_producer_kickout_threshold")]
    public uint ChunkProducerKickoutThreshold { get; set; }

    [JsonPropertyName("online_min_threshold")]
    public IEnumerable<uint> OnlineMinThreshold { get; set; } = new List<uint>();
    
    [JsonPropertyName("online_max_threshold")]
    public IEnumerable<uint> OnlineMaxThreshold { get; set; } = new List<uint>();

    [JsonPropertyName("gas_price_adjustment_rate")]
    public IEnumerable<uint> GasPriceAdjustmentRate { get; set; } = new List<uint>();

    [JsonPropertyName("runtime_config")]
    public RuntimeConfig RuntimeConfig { get; set; }
    
    [JsonPropertyName("validators")]
    public IEnumerable<Validator> Validators { get; set; } = new List<Validator>();

    [JsonPropertyName("transaction_validity_period")]
    public uint TransactionValidityPeriod { get; set; }
    
    [JsonPropertyName("protocol_reward_rate")]
    public IEnumerable<uint> ProtocolRewardRate { get; set; } = new List<uint>();

    [JsonPropertyName("max_inflation_rate")]
    public IEnumerable<uint> MaxInflationRate { get; set; } = new List<uint>();
    
    [JsonPropertyName("total_supply")]
    public string TotalSupply { get; set; }

    [JsonPropertyName("num_blocks_per_year")]
    public uint NumBlocksPerYear { get; set; }
    
    [JsonPropertyName("protocol_treasury_account")]
    public string ProtocolTreasuryAccount { get; set; }

    [JsonPropertyName("fishermen_threshold")]
    public string FishermenThreshold { get; set; }
    
    [JsonPropertyName("minimum_stake_divisor")]
    public uint MinimumStakeDivisor { get; set; }

}

public class RuntimeConfig
{
    [JsonPropertyName("storage_amount_per_byte")]
    public string StorageAmountPerByte { get; set; }
    
    [JsonPropertyName("transaction_costs")]
    public TransactionCosts TransactionCosts { get; set; }
    
    [JsonPropertyName("wasm_config")]
    public uint WasmConfig { get; set; }

    [JsonPropertyName("account_creation_config")]
    public uint AccountCreationConfig { get; set; }
}

public class Validator
{
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }
    [JsonPropertyName("public_key")]
    public string PublicKey { get; set; }
    [JsonPropertyName("amount")]
    public string Amount { get; set; }
}

public class TransactionCosts
{
    [JsonPropertyName("action_receipt_creation_config")]
    public object ActionReceiptCreationConfig { get; set; }
    
    [JsonPropertyName("data_receipt_creation_config")]
    public object DataReceiptCreationConfig { get; set; }

    [JsonPropertyName("action_creation_config")]
    public object AccountCreationConfig { get; set; }
    
    [JsonPropertyName("storage_usage_config")]
    public object StorageUsageConfig { get; set; }

    [JsonPropertyName("burnt_gas_reward")] 
    public IEnumerable<uint> BurntGasReward { get; set; } = new List<uint>();

    [JsonPropertyName("pessimistic_gas_price_inflation_ratio")]
    public IEnumerable<uint> PessimisticGasPriceInflationRatio { get; set; } = new List<uint>();
}

public class WasmConfig
{
    [JsonPropertyName("ext_costs")]
    public object ExtCosts { get; set; }
    
    [JsonPropertyName("grow_mem_cost")]
    public uint GrowMemCost { get; set; }
    
    [JsonPropertyName("regular_op_cost")]
    public uint RegularOpCost { get; set; }
    
    [JsonPropertyName("limit_config")]
    public object LimitConfig { get; set; }
}

public class AccountCreationConfig
{
    [JsonPropertyName("min_allowed_top_level_account_length")]
    public uint MinAllowedTopLevelAccountLength { get; set; }
    
    [JsonPropertyName("registrar_account_id")]
    public string RegistrarAccountId { get; set; }
}