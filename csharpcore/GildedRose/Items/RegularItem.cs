using GildedRose.Interfaces;
using System;

namespace GildedRose.Items
{
    public class RegularItem : IItem, IUpdateableItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public RegularItem(string name, int sellIn, int quality)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can't be null or empty");
            }

            if (sellIn < 0)
            {
                throw new ArgumentOutOfRangeException($"SellIn must be bigger than 0");
            }

            if (!QualityLimits.CheckIfQualityIsInLimit(quality))
            {
                throw new ArgumentOutOfRangeException($"Quality must between ${QualityLimits.QUALITY_LOWER_LIMIT} and {QualityLimits.QUALITY_UPPER_LIMIT}");
            }

            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public void Update()
        {
            SellIn -= 1;
            if (Quality > QualityLimits.QUALITY_LOWER_LIMIT)
            {
                UpdateQuality();
            }
        }

        private void UpdateQuality()
        {
            if (SellIn < 0)
            {
                Quality -= 2;
            }
            else
            {
                Quality -= 1;
            }

            EnsureQualityLimit();
        }

        private void EnsureQualityLimit()
        {
            if (Quality < QualityLimits.QUALITY_LOWER_LIMIT)
            {
                Quality = QualityLimits.QUALITY_LOWER_LIMIT;
            }
        }
    }
}
