using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using DotnetNearSdk.NearRPC.Types;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class GasNearRpcClientTests
{
    private IGasNearRpcClient _nearRpcClient;

    public GasNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient(Cluster.TestNet);
    }
    
    [Fact]
    public async Task GetGasPriceAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new int[]
        {
            93857939
        };
        
        //act
        var result = await _nearRpcClient.GetGasPriceAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Error);
        Assert.NotNull(result.Result);
        Assert.NotEmpty(result.Result.GasPrice);
    }
    
    [Fact]
    public async Task GetGasPriceAsync_ShouldReturnErrorResponse()
    {
        //arrange
        var parameters = new int[]
        {
            93
        };
        
        //act
        var result = await _nearRpcClient.GetGasPriceAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Result);
        Assert.NotNull(result.Error);
    }
}