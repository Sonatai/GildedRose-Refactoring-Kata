using FluentAssertions;
using GildedRose.Interfaces;
using GildedRose.Items;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseTests;

[TestFixture]
public class BackstageTests
{
    /*
        "Normal Item" = no special item
        "Brie" = "Aged Brie"
        "Backstage" = "Backstage passes to a TAFKAL80ETC concert"
        "Sulfuras" = "Sulfuras, Hand of Ragnaros"
    */

    [Test]
    public void UpdateBackstageItem1()
    {
        //Arrange
        IList<IItem> items = new List<IItem>
        {
            new BackstageItem(11, 41)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(10);
        item.Quality.Should().Be(42);
    }

    [Test]
    public void UpdateBackstageItem2()
    {
        //Arrange
        IList<IItem> items = new List<IItem>
        {
            new BackstageItem(6, 41)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(5);
        item.Quality.Should().Be(43);
    }

    [Test]
    public void UpdateBackstageItem3()
    {
        //Arrange
        IList<IItem> items = new List<IItem>
        {
            new BackstageItem(5, 41)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(4);
        item.Quality.Should().Be(44);
    }

    [Test]
    public void UpdateBackstageItem4()
    {
        //Arrange
        IList<IItem> items = new List<IItem>
        {
            new BackstageItem(0, 41)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(-1);
        item.Quality.Should().Be(0);
    }

    [Test]
    public void UpdateBackstageItem5()
    {
        //Arrange
        IList<IItem> items = new List<IItem>
        {
            new BackstageItem(11, 50)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(10);
        item.Quality.Should().Be(50);
    }

    [Test]
    public void UpdateBackstageItem6()
    {
        //Arrange
        IList<IItem> items = new List<IItem>
        {
            new BackstageItem(6, 50)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(5);
        item.Quality.Should().Be(50);
    }

    [Test]
    public void UpdateBackstageItem7()
    {
        //Arrange
        IList<IItem> items = new List<IItem>
        {
            new BackstageItem(5, 50)
        };

        GildedRose.GildedRose app = new(items);

        //Act
        app.UpdateQuality();

        //Assert
        IItem item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(4);
        item.Quality.Should().Be(50);
    }
}