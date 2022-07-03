using DotnetNearSdk.NearRPC.JsonRpcMessages;
using DotnetNearSdk.NearRPC.Models.Network;

namespace DotnetNearSdk.NearRPC.Interfaces;

public interface INetworkNearRpcClient
{
    /// <summary>
    /// Returns general status of a given node (sync status, nearcore node version, protocol version, etc), and the current set of validators (status).
    /// </summary>
    /// <returns>A task which may return a get node status result.</returns>
    public Task<JsonRpcResponseObject<GetStatusResult>> GetNodeStatusAsync();
    
    /// <summary>
    /// Returns the current state of node network connections (network_info).
    /// </summary>
    /// <returns>A task which may return a get network info result.</returns>
    public Task<JsonRpcResponseObject<GetNetworkInfoResult>> GetNetworkInfoAsync();

    /// <summary>
    /// Queries active validators on the network returning details and the state of validation on the blockchain (validators).
    /// </summary>
    /// <param name="parameters">["block hash"], [block number], or [null] for the latest block</param>
    /// <returns>A task which may return a get validation status result.</returns>
    public Task<JsonRpcResponseObject<GetValidationStatusResult>> GetValidationStatusAsync(object parameters = null);

}