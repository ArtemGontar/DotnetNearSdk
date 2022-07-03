using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class BlockNearRpcClientTests
{
    private IBlockNearRpcClient _nearRpcClient;

    public BlockNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient("https://rpc.testnet.near.org");
    }
    
    [Fact]
    // [InlineData("A5uBC3AXhAhYpMfVUDU48BmU86NHvW57YnJtCXvTGhEK")]
    // [InlineData(93373159)]
    public async Task GetBlockDetailsAsync_ShouldReturnValidResponse() //params object[] parameters
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
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Header);
        Assert.NotNull(result.Result.Chunks);
        Assert.NotEmpty(result.Result.Author);
    }
    
    [Fact]
    //[InlineData(93373159)]
    //[InlineData("final")]
    public async Task GetChangesInBlockAsync_ShouldReturnValidResponse() // params object[] parameters
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
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Changes);
        Assert.NotEmpty(result.Result.BlockHash);
    }
    
    [Fact]
    //[InlineData("final")]
    public async Task GetGasPriceAsync_ShouldReturnValidResponse() //params object[] parameters
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
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Header);
        Assert.NotNull(result.Result.Receipts);
        Assert.NotNull(result.Result.Transactions);
        Assert.NotEmpty(result.Result.Author);

    }
}