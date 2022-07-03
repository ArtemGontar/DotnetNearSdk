using System.Text.Json.Serialization;
using BlockMetrics.NearRPC.Models.Network;

namespace BlockMetrics.NearRPC.Models.Transaction;

public class SendTransactionResult
{
    [JsonPropertyName("status")]
    public TransactionStatus Status { get; set; }
    
    [JsonPropertyName("transaction")]
    public Transaction Transaction { get; set; }
    
    [JsonPropertyName("transaction_outcome")]
    public Outcome TransactionOutcome { get; set; }
    
    [JsonPropertyName("receipts_outcome")]
    public Outcome ReceiptsOutcome { get; set; }
}


public class TransactionStatus
{
    public string SuccessValue { get; set; }
}

public class Transaction
{
    [JsonPropertyName("signer_id")]
    public string signer_id { get; set; }
    
    [JsonPropertyName("public_key")]
    public string PublicKey { get; set; }
    
    [JsonPropertyName("nonce")]
    public uint Nonce { get; set; }
    
    [JsonPropertyName("receiver_id")]
    public string ReceiverId { get; set; }
    
    [JsonPropertyName("actions")]
    public Action Actions { get; set; }
    
    [JsonPropertyName("signature")]
    public string Signature { get; set; }
    
    [JsonPropertyName("hash")]
    public string Hash { get; set; }
}

public class Outcome
{
    [JsonPropertyName("proof")]
    public object[] Proof { get; set; }
    
    [JsonPropertyName("block_hash")]
    public string BlockHash { get; set; }
    
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("outcome")]
    public OutcomeInternal OutcomeInternal { get; set; }
}

public class Action
{
    public object Transfer { get; set; }
}

public class OutcomeInternal
{
    [JsonPropertyName("logs")]
    public object[] Logs { get; set; }
    
    [JsonPropertyName("receipt_ids")]
    public string[] ReceiptIds { get; set; }
    
    [JsonPropertyName("gas_burnt")]
    public ulong GasBurnt { get; set; }
    
    [JsonPropertyName("tokens_burnt")]
    public string TokensBurnt { get; set; }
    
    [JsonPropertyName("executor_id")]
    public string ExecutorId { get; set; }
    
    [JsonPropertyName("status")]
    public object Status { get; set; }
}