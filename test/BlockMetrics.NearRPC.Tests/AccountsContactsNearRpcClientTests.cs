using System.Threading.Tasks;
using DotnetNearSdk.NearRPC.Interfaces;
using Xunit;

namespace DotnetNearSdk.NearRPC.Tests;

public class AccountsContactsNearRpcClientTests
{
    private IAccountsContractsRpcClient _nearRpcClient;

    public AccountsContactsNearRpcClientTests()
    {
        _nearRpcClient = new NearRpcClient("https://rpc.testnet.near.org");
    }
    
    [Fact]
    public async Task ViewAccountAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            request_type = "view_account",
            finality = "final",
            account_id = "nearkat.testnet"
        };
        
        //act
        var result = await _nearRpcClient.ViewAccountAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotNull(result.Result.Changes);
        Assert.NotEmpty(result.Result.BlockHash);
    }
    
    [Fact]
    public async Task ViewAccountChangesAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            changes_type = "account_changes",
            account_ids = new string[]{"nearkat.testnet"},
            block_id = 93857939
        };
        
        //act
        var result = await _nearRpcClient.ViewAccountChangesAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotEmpty(result.Result.BlockHash);
    }
    
    [Fact]
    public async Task ViewContractCodeAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            request_type = "view_code",
            finality = "final",
            account_id = "guest-book.testnet"
        };
        
        //act
        var result = await _nearRpcClient.ViewContractCodeAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotEmpty(result.Result.BlockHash);
        Assert.NotEmpty(result.Result.CodeBase64);
    }
    
    [Fact]
    public async Task ViewContractStateAsync_ShouldReturnValidResponse()
    {
        //arrange
        var parameters = new
        {
            request_type = "view_state",
            finality = "final",
            account_id = "example.testnet",
            prefix_base64 = ""
        };
        
        //act
        var result = await _nearRpcClient.ViewContractStateAsync(parameters);
        
        //assert
        Assert.NotNull(result);
        Assert.NotNull(result.Result);
        Assert.NotEmpty(result.Result.BlockHash);
    }
}