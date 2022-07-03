using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.JsonRpcMessages;

/// <summary>
/// Type for represent rpc error info
/// </summary>
public class RpcError
{
    /// <summary>
    /// Error name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Error cause
    /// </summary>
    [JsonPropertyName("cause")]
    public RpcErrorCause Cause { get; set; }
    
    /// <summary>
    /// Error code
    /// </summary>
    [Obsolete("The fields code, data, and message in the structure above are considered legacy ones and might be deprecated in the future. Please, don't rely on them.")]
    [JsonPropertyName("code")]
    public int Code { get; set; }
    
    /// <summary>
    /// Error data
    /// </summary>
    [Obsolete("The fields code, data, and message in the structure above are considered legacy ones and might be deprecated in the future. Please, don't rely on them.")]
    [JsonPropertyName("data")]
    public string Data { get; set; }
    
    /// <summary>
    /// Error message
    /// </summary>
    [Obsolete("The fields code, data, and message in the structure above are considered legacy ones and might be deprecated in the future. Please, don't rely on them.")]
    [JsonPropertyName("message")]
    public string Message { get; set; }
}

public class RpcErrorCause
{
    [JsonPropertyName("info")]
    public object Info { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
}