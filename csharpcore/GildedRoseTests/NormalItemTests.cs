using FluentAssertions;
using GildedRose.Interfaces;
using GildedRose.Items;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseTests;

[TestFixture]
public class NormalItemTests
{
    /*
       "Normal Item" = no special item
       "Brie" = "Aged Brie"
       "Backstage" = "Backstage passes to a TAFKAL80ETC concert"
       "Sulfuras" = "Sulfuras, Hand of Ragnaros"
     */

    [Test]
    public void UpdateNormalItem1()
    {
        //Arrange
        IList<IItem> items = new List<IItem> {
            new RegularItem("Great Platypus (Pet)",30,43)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(42);
        item.SellIn.Should().Be(29);
    }

    [Test]
    public void UpdateNormalItem2()
    {
        //Arrange
        IList<IItem> items = new List<IItem> {
            new RegularItem("Great Platypus (Pet)",1,44)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(43);
        item.SellIn.Should().Be(0);
    }

    [Test]
    public void UpdateNormalItem3()
    {
        //Arrange
        IList<IItem> items = new List<IItem> {
            new RegularItem("Great Platypus (Pet)",0,44)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(42);
        item.SellIn.Should().Be(-1);
    }

    [Test]
    public void UpdateNormalItem4()
    {
        //Arrange
        IList<IItem> items = new List<IItem> {
            new RegularItem("Great Platypus (Pet)",30,0)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(0);
        item.SellIn.Should().Be(29);
    }

    [Test]
    public void UpdateNormalItem5()
    {
        //Arrange
        IList<IItem> items = new List<IItem> {
            new RegularItem("Great Platypus (Pet)",1,0)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(0);
        item.SellIn.Should().Be(0);
    }
}