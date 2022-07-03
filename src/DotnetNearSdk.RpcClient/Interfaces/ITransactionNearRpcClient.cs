using DotnetNearSdk.NearRPC.JsonRpcMessages;
using DotnetNearSdk.NearRPC.Models.Transaction;

namespace DotnetNearSdk.NearRPC.Interfaces;

public interface ITransactionNearRpcClient
{
    /// <summary>
    /// Sends a transaction and immediately returns transaction hash (broadcast_tx_async).
    /// </summary>
    /// <param name="parameters">SignedTransaction encoded in base64</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<string>> SendTransactionAsync(object parameters = null);
    
    /// <summary>
    /// Sends a transaction and waits until transaction is fully complete. (Has a 10 second timeout) (broadcast_tx_commit).
    /// </summary>
    /// <param name="parameters">SignedTransaction encoded in base64</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<SendTransactionResult>> SendTransactionAwait(object parameters = null);

}