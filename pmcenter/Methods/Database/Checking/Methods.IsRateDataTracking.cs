using static pmcenter.Conf;

namespace pmcenter
{
    public static partial class Methods
    {
        public static bool IsRateDataTracking(long UID)
        {
            foreach (RateData Data in Vars.RateLimits)
            {
                if (Data.UID == UID) { return true; }
            }
            return false;
        }
    }
}
