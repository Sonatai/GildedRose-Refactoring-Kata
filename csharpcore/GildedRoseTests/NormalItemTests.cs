using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using GildedRoseKata;
using NUnit.Framework;

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
        IList<Item> items = new List<Item> { new Item { Name = "Great Platypus (Pet)", SellIn = 30, Quality = 43 } };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(42);
        item.SellIn.Should().Be(29);
    }

    [Test]
    public void UpdateNormalItem2()
    {
        //Arrange
        IList<Item> items = new List<Item> { new Item { Name = "Great Platypus (Pet)", SellIn = 1, Quality = 44 } };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(43);
        item.SellIn.Should().Be(0);
    }
    
    [Test]
    public void UpdateNormalItem3()
    {
        //Arrange
        IList<Item> items = new List<Item> { new Item { Name = "Great Platypus (Pet)", SellIn = 0, Quality = 44 } };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(42);
        item.SellIn.Should().Be(-1);
    }
    
    [Test]
    public void UpdateNormalItem4()
    {
        //Arrange
        IList<Item> items = new List<Item> { new Item { Name = "Great Platypus (Pet)", SellIn = 30, Quality = 0 } };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(0);
        item.SellIn.Should().Be(29);
    }
    
    [Test]
    public void UpdateNormalItem5()
    {
        //Arrange
        IList<Item> items = new List<Item> { new Item { Name = "Great Platypus (Pet)", SellIn = 1, Quality = 0 } };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Great Platypus (Pet)");
        item.Quality.Should().Be(0);
        item.SellIn.Should().Be(0);
    }
}