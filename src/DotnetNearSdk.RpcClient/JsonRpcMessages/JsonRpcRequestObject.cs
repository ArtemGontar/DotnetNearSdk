using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.JsonRpcMessages;

internal class JsonRpcRequestObject
{
    /// <summary>
    /// Request Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = "dontcare";
    
    /// <summary>
    /// Requesting Method
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; }

    /// <summary>
    /// Json Rpc
    /// </summary>
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; } = "2.0";

    /// <summary>
    /// Params
    /// </summary>
    [JsonPropertyName("params")]
    public object Params { get; set; }
}