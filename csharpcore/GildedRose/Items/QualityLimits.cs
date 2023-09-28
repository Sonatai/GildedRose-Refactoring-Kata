namespace GildedRose.Items
{
    public static class QualityLimits
    {
        public static readonly int QUALITY_UPPER_LIMIT = 49;
        public static readonly int QUALITY_LOWER_LIMIT = 0;

        public static bool CheckIfQualityIsInLimit(int quality)
        {
            return quality >= QUALITY_LOWER_LIMIT && quality <= QUALITY_UPPER_LIMIT;
        }
    }
}
