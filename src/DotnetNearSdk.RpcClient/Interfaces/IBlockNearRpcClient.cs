using DotnetNearSdk.NearRPC.JsonRpcMessages;
using DotnetNearSdk.NearRPC.Models.Block;

namespace DotnetNearSdk.NearRPC.Interfaces;

public interface IBlockNearRpcClient
{
    
    /// <summary>
    /// Queries network and returns block for given height or hash. You can also use finality param to return latest block details (block).
    /// </summary>
    /// <param name="parameters">finality OR block_id OR block_hash</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<GetBlockDetailsResult>> GetBlockDetailsAsync(params object[] parameters);
    
    /// <summary>
    /// Returns changes in block for given block height or hash. You can also use finality param to return latest block details (EXPERIMENTAL_changes_in_block).
    /// </summary>
    /// <param name="parameters">finality OR block_id OR block_hash</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<GetChangesInBlockResult>> GetChangesInBlockAsync(params object[] parameters);
    
    /// <summary>
    /// Returns details of a specific chunk. You can run a block details query to get a valid chunk hash. (chunk).
    /// </summary>
    /// <param name="parameters">chunk_id OR block_id, shard_id</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<GetChunkDetailsResult>> GetChunkDetailsAsync(params object[] parameters);
}