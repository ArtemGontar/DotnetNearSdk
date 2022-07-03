using DotnetNearSdk.NearRPC.Interfaces;
using DotnetNearSdk.NearRPC.JsonRpcMessages;

namespace DotnetNearSdk.NearRPC;

public interface INearRpcClient : 
    INetworkNearRpcClient, 
    IGasNearRpcClient, 
    ITransactionNearRpcClient, 
    IBlockNearRpcClient, 
    IAccountsContractsRpcClient,
    IAccessKeysNearRpcClient
{
}