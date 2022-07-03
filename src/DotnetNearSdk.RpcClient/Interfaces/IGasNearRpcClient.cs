using BlockMetrics.NearRPC.JsonRpcMessages;
using BlockMetrics.NearRPC.Models.Gas;

namespace BlockMetrics.NearRPC.Interfaces;

public interface IGasNearRpcClient
{
    /// <summary>
    /// Returns gas price for a specific block_height or block_hash. Using [null] will return the most recent block's gas price (gas_price).
    /// </summary>
    /// <param name="parameters">[block_height], ["block_hash"], or [null]</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<GetGasPriceResult>> GetGasPriceAsync(params object[] parameters);
}