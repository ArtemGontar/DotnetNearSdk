using System.Text.Json.Serialization;

namespace BlockMetrics.NearRPC.JsonRpcMessages;

public class JsonRpcRequestObject
{
    /// <summary>
    /// Request Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Requesting Method
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; }
    
    /// <summary>
    /// Json Rpc
    /// </summary>
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; }

    /// <summary>
    /// Params
    /// </summary>
    [JsonPropertyName("params")]
    public object Params { get; set; }
}