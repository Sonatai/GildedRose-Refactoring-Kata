using GildedRose.Interfaces;

namespace GildedRose.Items
{
    public class AgedBrieItem : IUpdateableItem
    {
        public string Name { get; private set; }
        public int SellIn { get; private set; }
        public int Quality { get; private set; }

        public AgedBrieItem(int sellIn, int quality)
        {
            Name = "Aged Brie";
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
