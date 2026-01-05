using C10.Debugging;

namespace C10;

public class C10Consts
{
    public const string LocalizationSourceName = "C10";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "83ef23166f7b4b41a772476dfe1698fe";
}
