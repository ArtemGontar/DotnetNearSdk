using System.Text.Json.Serialization;

namespace BlockMetrics.NearRPC.JsonRpcMessages;

public class JsonRpcResponseObject<T> where T : class
{
    /// <summary>
    /// Response Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Json Rpc
    /// </summary>
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; }
    
    /// <summary>
    /// Method Result
    /// </summary>
    [JsonPropertyName("result")]
    public T Result { get; set; }
}