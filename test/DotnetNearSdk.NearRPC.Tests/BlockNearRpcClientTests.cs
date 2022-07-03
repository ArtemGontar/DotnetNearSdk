using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using DotnetNearSdk.NearRPC.Types;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class BlockNearRpcClientTests
{
    private IBlockNearRpcClient _nearRpcClient;

    public BlockNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient(Cluster.TestNet);
    }
    
    [Fact]
    public async Task GetBlockDetailsAsync_ShouldReturnValidResponse() //object parameters = null
    {
        //arrange
        var parameters = new
        {
            finality = "final"
        };
        
        //act
        var result = await _nearRpcClient.GetBlockDetailsAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Error);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Header);
        Assert.NotNull(result.Result.Chunks);
        Assert.NotEmpty(result.Result.Author);
    }
    
    [Fact]
    public async Task GetBlockDetailsAsync_ShouldReturnErrorResponse()
    {
        //arrange
        var parameters = new
        {
        };
        
        //act
        var result = await _nearRpcClient.GetBlockDetailsAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Result);
        Assert.NotNull(result.Error);
    }
    
    [Fact]
    public async Task GetChangesInBlockAsync_ShouldReturnValidResponse() // object parameters = null
    {
        //arrange
        var parameters = new
        {
            block_id = "2ofeDYvBebDZvzcUzVqC96qcmStGuapwuC9zoSMBHr61"
        };
        
        //act
        var result = await _nearRpcClient.GetChangesInBlockAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Error);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Changes);
        Assert.NotEmpty(result.Result.BlockHash);
    }
    
    [Fact]
    public async Task GetChangesInBlockAsync_ShouldReturnErrorResponse()
    {
        //arrange
        var parameters = new
        {
        };
        
        //act
        var result = await _nearRpcClient.GetChangesInBlockAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Result);
        Assert.NotNull(result.Error);
    }
    
    [Fact]
    public async Task GetChunkDetailsAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            chunk_id = "HMDMNQcrsaNyqsVpdwaGat5fdY5eU8aP1toSCD6CNdU6",
        };
        
        //act
        var result = await _nearRpcClient.GetChunkDetailsAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Error);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Header);
        Assert.NotNull(result.Result.Receipts);
        Assert.NotNull(result.Result.Transactions);
        Assert.NotEmpty(result.Result.Author);

    }
    
    [Fact]
    public async Task GetChunkDetailsAsync_ShouldReturnErrorResponse()
    {
        //arrange
        var parameters = new
        {
        };
        
        //act
        var result = await _nearRpcClient.GetChunkDetailsAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.Null(result.Result);
        Assert.NotNull(result.Error);
    }

}