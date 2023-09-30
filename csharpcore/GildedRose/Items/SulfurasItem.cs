using GildedRose.Interfaces;

namespace GildedRose.Items
{
    public class SulfurasItem : IItem
    {
        public string Name { get; }
        public int SellIn { get; }
        public int Quality { get; }

        public SulfurasItem(int sellIn, int quality)
        {
            Name = "Sulfuras, Hand of Ragnaros";
            SellIn = sellIn;
            Quality = quality;
        }
    }
}
