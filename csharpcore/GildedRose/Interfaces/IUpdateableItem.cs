namespace GildedRose.Interfaces
{
    public interface IUpdateableItem : IItem
    {
        public new string Name { get; set; }
        public new int SellIn { get; set; }
        public new int Quality { get; set; }
        public void Update();
    }
}
