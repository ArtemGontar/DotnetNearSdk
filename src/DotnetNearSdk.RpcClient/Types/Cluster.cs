namespace DotnetNearSdk.NearRPC.Types;

public static class Cluster
{
    /// <summary>
    /// Betanet endpoint URL
    /// <inheritdoc cref="https://docs.near.org/docs/api/rpc"/>
    /// </summary>
    public static string BetaNet = "https://rpc.betanet.near.org";
    
    /// <summary>
    /// Testnet endpoint URL
    /// <inheritdoc cref="https://docs.near.org/docs/api/rpc"/>
    /// </summary>
    public static string TestNet = "https://rpc.testnet.near.org";
    
    /// <summary>
    /// Mainnet endpoint URL
    /// <inheritdoc cref="https://docs.near.org/docs/api/rpc"/>
    /// </summary>
    public static string MainNet = "https://rpc.mainnet.near.org";
    
    public static string LocalNet = "http://localhost:3030";
    /// <summary>
    /// Archive Mainnet endpoint URL
    /// Querying historical data (older than 5 epochs or ~2.5 days), you may get responses that the data is not available anymore. In that case, archival RPC nodes will come to your rescue
    /// <inheritdoc cref="https://docs.near.org/docs/api/rpc"/>
    /// </summary>
    public static string ArchiveMainNet = "https://archival-rpc.mainnet.near.org";
    /// <summary>
    /// Archive Testnet endpoint URL
    /// Querying historical data (older than 5 epochs or ~2.5 days), you may get responses that the data is not available anymore. In that case, archival RPC nodes will come to your rescue
    /// <inheritdoc cref="https://docs.near.org/docs/api/rpc"/>
    /// </summary>
    public static string ArchiveTestNet = "https://archival-rpc.testnet.near.org";
}