namespace GildedRose.Interfaces
{
    public interface IItem
    {
        public string Name { get; }
        public int SellIn { get; }
        public int Quality { get; }
    }
}
