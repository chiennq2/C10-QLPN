using C10.MasterData.Debugging;

namespace C10.MasterData;

public class MasterDataConsts
{
    public const string LocalizationSourceName = "MasterData";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ead74a9ecff24ce087415cdc29c89679";

    public const int MaxMaLength = 50;
    public const int MaxTenLength = 255;
}
