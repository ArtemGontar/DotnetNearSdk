using BlockMetrics.NearRPC.Interfaces;
using BlockMetrics.NearRPC.JsonRpcMessages;

namespace BlockMetrics.NearRPC;

public interface INearRpcClient : 
    INetworkNearRpcClient, 
    IGasNearRpcClient, 
    ITransactionNearRpcClient, 
    IBlockNearRpcClient, 
    IAccountsContractsRpcClient,
    IAccessKeysNearRpcClient
{
}