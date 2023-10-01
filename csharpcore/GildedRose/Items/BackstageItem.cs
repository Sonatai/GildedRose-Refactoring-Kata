using GildedRose.Interfaces;

namespace GildedRose.Items
{
    public class BackstageItem : IUpdateableItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public BackstageItem(int sellIn, int quality)
        {
            Name = "Backstage passes to a TAFKAL80ETC concert";
            SellIn = sellIn;
            Quality = quality;
        }

        public void Update()
        {
            UpdateBeforeSellIn();

            SellIn -= 1;

            UpdateAfterSellIn();
        }

        private void UpdateBeforeSellIn()
        {
            if (SellIn < 6)
            {
                Quality += 2;
            }
            else if (SellIn < 11)
            {
                Quality += 1;
            }

            EnsureQualityLimit();
        }

        private void UpdateAfterSellIn()
        {
            if (SellIn < 0)
            {
                Quality = 0;
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
