using BlockMetrics.NearRPC.JsonRpcMessages;
using BlockMetrics.NearRPC.Models.Transaction;

namespace BlockMetrics.NearRPC.Interfaces;

public interface ITransactionNearRpcClient
{
    /// <summary>
    /// Sends a transaction and immediately returns transaction hash (broadcast_tx_async).
    /// </summary>
    /// <param name="parameter">SignedTransaction encoded in base64</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<string>> SendTransactionAsync(params object[] parameter);
    
    /// <summary>
    /// Sends a transaction and waits until transaction is fully complete. (Has a 10 second timeout) (broadcast_tx_commit).
    /// </summary>
    /// <param name="parameter">SignedTransaction encoded in base64</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<SendTransactionResult>> SendTransactionAwait(params object[] parameter);

}