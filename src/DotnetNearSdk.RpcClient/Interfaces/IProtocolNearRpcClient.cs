using DotnetNearSdk.NearRPC.JsonRpcMessages;
using DotnetNearSdk.NearRPC.Models.Protocol;


namespace DotnetNearSdk.NearRPC.Interfaces;

public interface IProtocolNearRpcClient
{
    /// <summary>
    /// Get current genesis configuration. (EXPERIMENTAL_genesis_config).
    /// </summary>
    /// <returns>Returns current genesis configuration.</returns>
    public Task<JsonRpcResponseObject<GetGenesisConfigResult>> GetGenesisConfigAsync();
}