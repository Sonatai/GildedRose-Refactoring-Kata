using GildedRose.Interfaces;
using System;

namespace GildedRose.Items
{
    public class RegularItem : IUpdateableItem
    {
        public string Name { get; private set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public RegularItem(string name, int sellIn, int quality)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can't be null or empty");
            }

            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public void Update()
        {
            SellIn -= 1;
            UpdateQuality();
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
