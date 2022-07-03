using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class GasNearRpcClientTests
{
    private IGasNearRpcClient _nearRpcClient;

    public GasNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient("https://rpc.testnet.near.org");
    }
    
    [Fact]
    // [InlineData("A5uBC3AXhAhYpMfVUDU48BmU86NHvW57YnJtCXvTGhEK")]
    // [InlineData(93373159)]
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
        Assert.NotNull(result.Result);
        Assert.NotEmpty(result.Result.GasPrice);
    }
}