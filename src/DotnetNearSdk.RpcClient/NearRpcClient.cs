using System.Text;
using System.Text.Json;
using DotnetNearSdk.NearRPC.Interfaces;
using DotnetNearSdk.NearRPC.JsonRpcMessages;
using DotnetNearSdk.NearRPC.Models.AccessKey;
using DotnetNearSdk.NearRPC.Models.Accounts;
using DotnetNearSdk.NearRPC.Models.Block;
using DotnetNearSdk.NearRPC.Models.Contracts;
using DotnetNearSdk.NearRPC.Models.Gas;
using DotnetNearSdk.NearRPC.Models.Network;
using DotnetNearSdk.NearRPC.Models.Protocol;
using DotnetNearSdk.NearRPC.Models.Transaction;

namespace DotnetNearSdk.NearRPC;

public class NearRpcClient : INearRpcClient
{
    public Uri NodeAddress { get; set; }

    private HttpClient _httpClient;

    public NearRpcClient(string url)
    {
        NodeAddress = new Uri(url);
        _httpClient = new HttpClient()
        {
            BaseAddress = NodeAddress
        };
    }

    /// <inheritdoc cref="INetworkNearRpcClient"/>
    public async Task<JsonRpcResponseObject<GetStatusResult>> GetNodeStatusAsync()
    {
        return await SendRequestAsync<GetStatusResult>("status");
    }

    /// <inheritdoc cref="INetworkNearRpcClient"/>
    public async Task<JsonRpcResponseObject<GetNetworkInfoResult>> GetNetworkInfoAsync()
    {
        return await SendRequestAsync<GetNetworkInfoResult>("network_info");
    }
    
    /// <inheritdoc cref="INetworkNearRpcClient"/>
    public async Task<JsonRpcResponseObject<GetValidationStatusResult>> GetValidationStatusAsync(object parameters = null)
    {
        return await SendRequestAsync<GetValidationStatusResult>("validators", parameters);
    }
    
    /// <inheritdoc cref="IGasNearRpcClient"/>
    public async Task<JsonRpcResponseObject<GetGasPriceResult>> GetGasPriceAsync(object parameters = null)
    {
        return await SendRequestAsync<GetGasPriceResult>("gas_price", parameters);
    }
    
    /// <inheritdoc cref="ITransactionNearRpcClient"/>
    public async Task<JsonRpcResponseObject<string>> SendTransactionAsync(object parameters = null)
    {
        return await SendRequestAsync<string>("broadcast_tx_async", parameters);
    }
    
    /// <inheritdoc cref="ITransactionNearRpcClient"/>
    public async Task<JsonRpcResponseObject<SendTransactionResult>> SendTransactionAwait(object parameters = null)
    {
        return await SendRequestAsync<SendTransactionResult>("broadcast_tx_commit", parameters);
    }
    
    /// <inheritdoc cref="IBlockNearRpcClient"/>
    public async Task<JsonRpcResponseObject<GetBlockDetailsResult>> GetBlockDetailsAsync(object parameters = null)
    {
        return await SendRequestAsync<GetBlockDetailsResult>("block", parameters);
    }
    
    /// <inheritdoc cref="IBlockNearRpcClient"/>
    public async Task<JsonRpcResponseObject<GetChangesInBlockResult>> GetChangesInBlockAsync(object parameters = null)
    {
        return await SendRequestAsync<GetChangesInBlockResult>("EXPERIMENTAL_changes_in_block", parameters);
    }
    
    /// <inheritdoc cref="IBlockNearRpcClient"/>
    public async Task<JsonRpcResponseObject<GetChunkDetailsResult>> GetChunkDetailsAsync(object parameters = null)
    {
        return await SendRequestAsync<GetChunkDetailsResult>("chunk", parameters);
    }

    /// <inheritdoc cref="IAccountsContractsRpcClient"/>
    public async Task<JsonRpcResponseObject<ViewAccountResult>> ViewAccountAsync(object parameters = null)
    {
        return await SendRequestAsync<ViewAccountResult>("query", parameters);
    }

    /// <inheritdoc cref="IAccountsContractsRpcClient"/>
    public async Task<JsonRpcResponseObject<ViewAccountChangesResult>> ViewAccountChangesAsync(object parameters = null)
    {
        return await SendRequestAsync<ViewAccountChangesResult>("EXPERIMENTAL_changes", parameters);
    }

    /// <inheritdoc cref="IAccountsContractsRpcClient"/>
    public async Task<JsonRpcResponseObject<ViewContractCodeResult>> ViewContractCodeAsync(object parameters = null)
    {
        return await SendRequestAsync<ViewContractCodeResult>("query", parameters);
    }

    /// <inheritdoc cref="IAccountsContractsRpcClient"/>
    public async Task<JsonRpcResponseObject<ViewContractStateResult>> ViewContractStateAsync(object parameters = null)
    {
        return await SendRequestAsync<ViewContractStateResult>("query", parameters);
    }
    
    /// <inheritdoc cref="IAccessKeysNearRpcClient"/>
    public async Task<JsonRpcResponseObject<ViewAccessKeyResult>> ViewAccessKeyAsync(object parameters = null)
    {
        return await SendRequestAsync<ViewAccessKeyResult>("query", parameters);
    }

    /// <inheritdoc cref="IAccessKeysNearRpcClient"/>
    public async Task<JsonRpcResponseObject<ViewAccessKeyListResult>> ViewAccessKeyListAsync(object parameters = null)
    {
        return await SendRequestAsync<ViewAccessKeyListResult>("query", parameters);
    }

    /// <inheritdoc cref="IAccessKeysNearRpcClient"/>
    public async Task<JsonRpcResponseObject<ViewAccessKeyChangesResult>> ViewAccessKeyChangesAsync(object parameters = null)
    {
        return await SendRequestAsync<ViewAccessKeyChangesResult>("EXPERIMENTAL_changes", parameters);
    }
    
    public async Task<JsonRpcResponseObject<GetGenesisConfigResult>> GetGenesisConfigAsync()
    {
        return await SendRequestAsync<GetGenesisConfigResult>("EXPERIMENTAL_genesis_config");
    }
    
    /// <summary>
    /// Send request async
    /// </summary>
    /// <param name="method">The request's RPC method.</param>
    ///  <param name="parameters">(Optional) The request's RPC parameters.</param>
    /// <typeparam name="T">The type of the request result.</typeparam>
    /// <returns>A task which may return a request result.</returns>
    //TODO: Return an error
    private async Task<JsonRpcResponseObject<T>> SendRequestAsync<T>(string method, object parameters = null) where T : class
    {
        var requestObject = new JsonRpcRequestObject()
        {
            Method = method,
            Params = parameters
        };

        var json = JsonSerializer.Serialize(requestObject);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        using var httpReq = new HttpRequestMessage(HttpMethod.Post, (string)null)
        {
            Content = data
        };

        using var response = await _httpClient.SendAsync(httpReq).ConfigureAwait(false);
        var resultObject = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<JsonRpcResponseObject<T>>(resultObject);
        return result;
    }
}