using System.Text.Json.Serialization;

namespace BlockMetrics.NearRPC.Models.Gas;

public class GetGasPriceResult
{
    /// <summary>
    /// Gas price
    /// </summary>
    [JsonPropertyName("gas_price")]
    public string GasPrice { get; set; }
}