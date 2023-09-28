using GildedRose.Interfaces;
using System;

namespace GildedRose.Items
{
    public class AgedBrieItem : IItem, IUpdateableItem
    {
        private readonly int QUALITY_LIMIT = 49;

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public AgedBrieItem(int sellIn, int quality)
        {
            if (sellIn < 0)
            {
                throw new ArgumentOutOfRangeException($"SellIn must be bigger than 0");
            }

            if (!QualityLimits.CheckIfQualityIsInLimit(quality))
            {
                throw new ArgumentOutOfRangeException($"Quality must between ${QualityLimits.QUALITY_LOWER_LIMIT} and {QualityLimits.QUALITY_UPPER_LIMIT}");
            }

            Name = "Aged Brie";
            SellIn = sellIn;
            Quality = quality;
        }

        public void Update()
        {
            SellIn -= 1;
            if (Quality <= QualityLimits.QUALITY_UPPER_LIMIT)
            {
                UpdateQuality();
            }
        }

        private void UpdateQuality()
        {
            if (SellIn < 0)
            {
                Quality += 2;

            }
            else
            {
                Quality += 1;
            }

            EnsureQualityLimit();
        }

        private void EnsureQualityLimit()
        {
            if (Quality > QualityLimits.QUALITY_UPPER_LIMIT)
            {
                Quality = QualityLimits.QUALITY_UPPER_LIMIT;
            }
        }
    }
}
