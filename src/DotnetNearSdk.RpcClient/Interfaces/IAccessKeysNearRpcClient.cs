using DotnetNearSdk.NearRPC.JsonRpcMessages;
using DotnetNearSdk.NearRPC.Models.AccessKey;

namespace DotnetNearSdk.NearRPC.Interfaces;

public interface IAccessKeysNearRpcClient
{
    /// <summary>
    /// Returns information about a single access key for given account.
    /// If permission of the key is FunctionCall, it will return more details such as the allowance, receiver_id, and method_names. (query).
    /// </summary>
    /// <param name="parameters">request_type: view_access_key, finality OR block_id, account_id: "example.testnet", public_key: "example.testnet's public key"</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<ViewAccessKeyResult>> ViewAccessKeyAsync(object parameters = null);

    /// <summary>
    /// Returns ALL access keys for a given account. (query).
    /// </summary>
    /// <param name="parameters">request_type: view_account, finality OR block_id,account_id: "example.testnet"</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<ViewAccessKeyListResult>> ViewAccessKeyListAsync(object parameters = null);

    
    /// <summary>
    /// Returns access key/key changes in a specific block. You can query multiple keys by passing an array of objects containing the account_id and public_key or account_ids (EXPERIMENTAL_changes).
    /// </summary>
    /// <param name="parameters">changes_type: single_access_key_changes OR all_access_key_changes, keys: [{ account_id, public_key }] OR account_ids: [ "example.testnet", "example2.testnet"], finality OR block_id</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<ViewAccessKeyChangesResult>> ViewAccessKeyChangesAsync(object parameters = null);

}