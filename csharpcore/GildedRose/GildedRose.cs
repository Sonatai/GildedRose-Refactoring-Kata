using System.Collections.Generic;

namespace GildedRose;

public class GildedRose
{
    private readonly IList<Item> _items;

    public GildedRose(IList<Item> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (Item item in _items)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                //Nothing happen here :)
            }
            else if (item.Name == "Aged Brie")
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;
                }

                item.SellIn -= 1;

                if (item.SellIn < 0)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality += 1;
                    }
                }
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;


                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality += 1;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality += 1;
                        }
                    }
                }

                item.SellIn -= 1;

                if (item.SellIn < 0)
                {
                    item.Quality = 0;
                }
            }
            else
            {
                if (item.Quality > 0)
                {
                    item.Quality -= 1;
                }

                item.SellIn -= 1;

                if (item.SellIn < 0)
                {
                    if (item.Quality > 0)
                    {
                        item.Quality -= 1;
                    }
                }
            }
        }
    }
}