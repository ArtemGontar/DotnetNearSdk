using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class NetworkNearRpcClientTests
{
    private INetworkNearRpcClient _nearRpcClient;

    public NetworkNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient("https://rpc.testnet.near.org");
    }

    [Fact]
    public async Task GetNodeStatusAsync_ShouldReturnValidResponse()
    {
        //act
        var result = await _nearRpcClient.GetNodeStatusAsync();
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Validators);
        Assert.NotNull(result.Result.Version);
        Assert.NotNull(result.Result.SyncInfo);
        Assert.NotNull(result.Result.RpcAddr);
    }
    
    [Fact]
    public async Task GetNetworkInfoAsync_ShouldReturnValidResponse()
    {
        //act
        var result = await _nearRpcClient.GetNetworkInfoAsync();
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.KnownProducers);
        Assert.NotNull(result.Result.ActivePeers);
    }
    
    [Fact]
    //[InlineData(null)]
    //[InlineData("A5uBC3AXhAhYpMfVUDU48BmU86NHvW57YnJtCXvTGhEK")]
    //[InlineData(93373159)]
    public async Task GetValidationStatusAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new string[]
        {
            "latest"
        };
        
        //act
        var result = await _nearRpcClient.GetValidationStatusAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.CurrentFishermen);
        Assert.NotNull(result.Result.NextFishermen);
        Assert.NotNull(result.Result.CurrentProposals);
        Assert.NotNull(result.Result.CurrentValidators);
        Assert.NotNull(result.Result.NextValidators);
    }
}