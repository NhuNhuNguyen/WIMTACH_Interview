using MyCollegeV1.Debugging;

namespace MyCollegeV1
{
    public class MyCollegeV1Consts
    {
        public const string LocalizationSourceName = "MyCollegeV1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "dd1b6cf7abc049f9819246241f716ff3";
    }
}
