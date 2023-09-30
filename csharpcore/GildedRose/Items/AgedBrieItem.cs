using GildedRose.Interfaces;

namespace GildedRose.Items
{
    public class AgedBrieItem : IUpdateableItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public AgedBrieItem(int sellIn, int quality)
        {
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
