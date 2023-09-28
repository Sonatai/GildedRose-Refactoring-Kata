using GildedRose.Interfaces;
using System;

namespace GildedRose.Items
{
    public class SulfurasItem : IItem
    {
        public string Name { get; }
        public int SellIn { get; }
        public int Quality { get; }

        public SulfurasItem(int sellIn, int quality)
        {
            if (sellIn < 0)
            {
                throw new ArgumentOutOfRangeException($"SellIn must be bigger than 0");
            }

            if (!QualityLimits.CheckIfQualityIsInLimit(quality))
            {
                throw new ArgumentOutOfRangeException($"Quality must between ${QualityLimits.QUALITY_LOWER_LIMIT} and {QualityLimits.QUALITY_UPPER_LIMIT}");
            }

            Name = "Sulfuras, Hand of Ragnaros";
            SellIn = sellIn;
            Quality = quality;
        }
    }
}
