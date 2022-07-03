using System.Text.Json.Serialization;

namespace DotnetNearSdk.NearRPC.Models.Gas;

public class GetGasPriceResult
{
    /// <summary>
    /// Gas price
    /// </summary>
    [JsonPropertyName("gas_price")]
    public string GasPrice { get; set; }
}