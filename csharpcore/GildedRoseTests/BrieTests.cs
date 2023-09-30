using FluentAssertions;
using GildedRose.Interfaces;
using GildedRose.Items;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseTests;

[TestFixture]
public class BrieTests
{
    /*
      "Normal Item" = no special item
      "Brie" = "Aged Brie"
      "Backstage" = "Backstage passes to a TAFKAL80ETC concert"
      "Sulfuras" = "Sulfuras, Hand of Ragnaros"
    */

    [Test]
    public void UpdateBrieItem1()
    {
        //Arrange
        IList<IItem> items = new List<IItem> {
            new AgedBrieItem(11,41)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Aged Brie");
        item.SellIn.Should().Be(10);
        item.Quality.Should().Be(42);
    }

    [Test]
    public void UpdateBrieItem2()
    {
        //Arrange
        IList<IItem> items = new List<IItem> {
            new AgedBrieItem(11,50)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Aged Brie");
        item.SellIn.Should().Be(10);
        item.Quality.Should().Be(50);
    }

    [Test]
    public void UpdateBrieItem3()
    {
        //Arrange
        IList<IItem> items = new List<IItem> {
            new AgedBrieItem(0,41)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Aged Brie");
        item.SellIn.Should().Be(-1);
        item.Quality.Should().Be(43);
    }
}