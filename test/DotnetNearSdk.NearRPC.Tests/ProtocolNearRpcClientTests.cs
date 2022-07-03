using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using DotnetNearSdk.NearRPC.Types;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class ProtocolNearRpcClientTests
{
    private IProtocolNearRpcClient _nearRpcClient;

    public ProtocolNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient(Cluster.TestNet);
    }

    [Fact]
    public async Task GetNodeStatusAsync_ShouldReturnValidResponse()
    {
        //act
        var result = await _nearRpcClient.GetGenesisConfigAsync();
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.Null(result.Error);
        Assert.NotNull(result.Result.Validators);
        Assert.NotNull(result.Result.MaxInflationRate);
        Assert.NotNull(result.Result.OnlineMaxThreshold);
        Assert.NotNull(result.Result.OnlineMinThreshold);
        Assert.NotNull(result.Result.ProtocolRewardRate);
    }
}