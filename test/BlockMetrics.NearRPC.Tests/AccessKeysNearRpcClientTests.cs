using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class AccessKeysNearRpcClientTests
{
    private IAccessKeysNearRpcClient _nearRpcClient;

    public AccessKeysNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient("https://rpc.testnet.near.org");
    }
    
    [Fact]
    public async Task ViewAccessKeyAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            request_type = "view_access_key",
            finality = "final",
            account_id = "client.chainlink.testnet",
            public_key = "ed25519:H9k5eiU4xXS3M4z8HzKJSLaZdqGdGwBG49o7orNC4eZW"
        };
        
        //act
        var result = await _nearRpcClient.ViewAccessKeyAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Permission);
        Assert.NotEmpty(result.Result.BlockHash);
    }
    
    [Fact]
    public async Task ViewAccessKeyListAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            request_type = "view_access_key_list",
            finality = "final",
            account_id = "example.testnet",
        };
        
        //act
        var result = await _nearRpcClient.ViewAccessKeyListAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Keys);
        Assert.NotEmpty(result.Result.BlockHash);
    }
    
    [Fact]
    public async Task ViewAccessKeyChangesAsync_SingleMode_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            changes_type = "single_access_key_changes",
            finality = "final",
            keys = new[]
            {
                new
                {
                    account_id = "example-acct.testnet",
                    public_key = "ed25519:25KEc7t7MQohAJ4EDThd2vkksKkwangnuJFzcoiXj9oM"
                }
            }
        };
        
        //act
        var result = await _nearRpcClient.ViewAccessKeyChangesAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Changes);
        Assert.NotEmpty(result.Result.BlockHash);
    }
    
    [Fact]
    public async Task ViewAccessKeyChangesAsync_AllMode_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            changes_type = "all_access_key_changes",
            //block_id = "4kvqE1PsA6ic1LG7S5SqymSEhvjqGqumKjAxnVdNN3ZH"
            finality = "final",
            account_ids = new string[]
            {
                "example-acct.testnet"
            }
        };
        
        //act
        var result = await _nearRpcClient.ViewAccessKeyChangesAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Changes);
        Assert.NotEmpty(result.Result.BlockHash);
    }
}