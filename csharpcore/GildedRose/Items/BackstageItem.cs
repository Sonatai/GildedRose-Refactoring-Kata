using GildedRose.Interfaces;
using System;

namespace GildedRose.Items
{
    public class BackstageItem : IItem, IUpdateableItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public BackstageItem(int sellIn, int quality)
        {
            if (sellIn < 0)
            {
                throw new ArgumentOutOfRangeException($"SellIn must be bigger than 0");
            }

            if (!QualityLimits.CheckIfQualityIsInLimit(quality))
            {
                throw new ArgumentOutOfRangeException($"Quality must between ${QualityLimits.QUALITY_LOWER_LIMIT} and {QualityLimits.QUALITY_UPPER_LIMIT}");
            }

            Name = "Backstage passes to a TAFKAL80ETC concert";
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
                Quality = 0;
            }
            else if (Quality >= 11)
            {
                Quality += 1;
            }
            else if (SellIn < 11)
            {
                Quality += 2;
            }
            else if (SellIn < 6)
            {
                Quality += 3;
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
