using GildedRose.Interfaces;
using GildedRose.Items;
using System;
using System.Collections.Generic;

namespace GildedRoseTests;

public static class TextTestFixture
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");
        List<IItem> items = new()
        {
            new RegularItem("Elixir of the Mongoose",5,7),
            new RegularItem("+5 Dexterity Vest",10,20),
             // this conjured item does not work properly yet
            new RegularItem("Conjured Mana Cake",3,6),
            new AgedBrieItem(2,0),
            new SulfurasItem(0,80),
            new SulfurasItem(-1,80),
            new BackstageItem(15,20),
            new BackstageItem(10,49),
            new BackstageItem(5,49),
        };

        GildedRose.GildedRose app = new(items);

        int days = 31;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (int i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (int j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }

            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}