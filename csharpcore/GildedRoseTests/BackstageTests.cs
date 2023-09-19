using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using GildedRose;
using NUnit.Framework;

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
        IList<Item> items = new List<Item>
        {
            new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 41 }
        };
        var app = new GildedRose.GildedRose(items);

        //Act
        app.UpdateQuality();

        //Assert
        var item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(10);
        item.Quality.Should().Be(42);
    }

    [Test]
    public void UpdateBackstageItem2()
    {
        //Arrange
        IList<Item> items = new List<Item>
        {
            new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 41 }
        };
        var app = new GildedRose.GildedRose(items);

        //Act
        app.UpdateQuality();

        //Assert
        var item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(5);
        item.Quality.Should().Be(43);
    }

    [Test]
    public void UpdateBackstageItem3()
    {
        //Arrange
        IList<Item> items = new List<Item>
        {
            new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 41 }
        };
        var app = new GildedRose.GildedRose(items);

        //Act
        app.UpdateQuality();

        //Assert
        var item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(4);
        item.Quality.Should().Be(44);
    }

    [Test]
    public void UpdateBackstageItem4()
    {
        //Arrange
        IList<Item> items = new List<Item>
        {
            new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 41 }
        };
        var app = new GildedRose.GildedRose(items);

        //Act
        app.UpdateQuality();

        //Assert
        var item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(-1);
        item.Quality.Should().Be(0);
    }

    [Test]
    public void UpdateBackstageItem5()
    {
        //Arrange
        IList<Item> items = new List<Item>
        {
            new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 50 }
        };
        var app = new GildedRose.GildedRose(items);

        //Act
        app.UpdateQuality();

        //Assert
        var item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(10);
        item.Quality.Should().Be(50);
    }

    [Test]
    public void UpdateBackstageItem6()
    {
        //Arrange
        IList<Item> items = new List<Item>
        {
            new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 50 }
        };
        var app = new GildedRose.GildedRose(items);

        //Act
        app.UpdateQuality();

        //Assert
        var item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(5);
        item.Quality.Should().Be(50);
    }

    [Test]
    public void UpdateBackstageItem7()
    {
        //Arrange
        IList<Item> items = new List<Item>
        {
            new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 50 }
        };
        var app = new GildedRose.GildedRose(items);

        //Act
        app.UpdateQuality();

        //Assert
        var item = items.First();
        item.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        item.SellIn.Should().Be(4);
        item.Quality.Should().Be(50);
    }
}