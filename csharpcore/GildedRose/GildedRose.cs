using GildedRose.Interfaces;
using System.Collections.Generic;

namespace GildedRose;

public class GildedRose
{
    private readonly IList<IItem> _items;

    public GildedRose(IList<IItem> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (IItem item in _items)
        {
            if (item is IUpdateableItem updateableItem)
            {
                updateableItem.Update();
            }
        }
    }
}