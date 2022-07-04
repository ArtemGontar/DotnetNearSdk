using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using DotnetNearSdk.NearRPC.Types;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class TransactionNearRpcClientTests
{
    private ITransactionNearRpcClient _nearRpcClient;

    public TransactionNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient(Cluster.TestNet);
    }

    [Fact]
    public async Task SendTransactionAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new string[]
        {
            "A5uBC3AXhAhYpMfVUDU48BmU86NHvW57YnJtCXvTGhEK"
        };
        
        //act
        var result = await _nearRpcClient.SendTransactionAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Error);
        Assert.NotNull(result.Result);
    }
    
    [Fact]
    public async Task SendTransactionAwait_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new string[]
        {
            "A5uBC3AXhAhYpMfVUDU48BmU86NHvW57YnJtCXvTGhEK"
        };
        
        //act
        var result = await _nearRpcClient.SendTransactionAwait(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Error);
        Assert.NotNull(result.Result);
    }
    
    [Fact]
    public async Task SendTransactionAsync_ShouldReturnErrorResponse()
    {
        //arrange
        var parameters = new string[]
        {
        };
        
        //act
        var result = await _nearRpcClient.SendTransactionAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Result);
        Assert.NotNull(result.Error);
    }
}