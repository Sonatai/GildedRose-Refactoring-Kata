using FluentAssertions;
using GildedRose.Interfaces;
using GildedRose.Items;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseTests;

[TestFixture]
public class LegendaryItemTests
{
    /*
       "Normal Item" = no special item
       "Brie" = "Aged Brie"
       "Backstage" = "Backstage passes to a TAFKAL80ETC concert"
       "Sulfuras" = "Sulfuras, Hand of Ragnaros"
     */

    [Test]
    public void UpdateLegendaryItem1()
    {
        //Arrange
        IList<IItem> items = new List<IItem>
        {
            new SulfurasItem(30,44)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Sulfuras, Hand of Ragnaros");
        item.Quality.Should().Be(44);
        item.SellIn.Should().Be(30);
    }
}