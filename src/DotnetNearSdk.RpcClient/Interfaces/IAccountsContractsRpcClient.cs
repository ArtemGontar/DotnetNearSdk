using DotnetNearSdk.NearRPC.JsonRpcMessages;
using DotnetNearSdk.NearRPC.Models.Accounts;
using DotnetNearSdk.NearRPC.Models.Contracts;

namespace DotnetNearSdk.NearRPC.Interfaces;

public interface IAccountsContractsRpcClient
{
    /// <summary>
    /// Returns basic account information (query).
    /// </summary>
    /// <param name="parameters">request_type: view_account, finality OR block_id,account_id: "example.testnet"</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<ViewAccountResult>> ViewAccountAsync(params object[] parameters);

    /// <summary>
    /// Returns account changes from transactions in a given account. (EXPERIMENTAL_changes).
    /// </summary>
    /// <param name="parameters">changes_type: account_changes, account_ids: ["example.testnet"], finality OR block_id</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<ViewAccountChangesResult>> ViewAccountChangesAsync(params object[] parameters);

    /// <summary>
    /// Returns the contract code (Wasm binary) deployed to the account. Please note that the returned code will be encoded in base64 (query).
    /// </summary>
    /// <param name="parameters">request_type: view_code, finality OR block_id, account_id: "guest-book.testnet",</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<ViewContractCodeResult>> ViewContractCodeAsync(params object[] parameters);

    /// <summary>
    /// Returns the state (key value pairs) of a contract based on the key prefix (base64 encoded). Pass an empty string for prefix_base64
    /// if you would like to return the entire state. Please note that the returned state will be base64 encoded as well. (query).
    /// </summary>
    /// <param name="parameters">request_type: view_code, finality OR block_id, account_id: "guest-book.testnet", prefix_base64: ""</param>
    /// <returns></returns>
    public Task<JsonRpcResponseObject<ViewContractStateResult>> ViewContractStateAsync(params object[] parameters);

}