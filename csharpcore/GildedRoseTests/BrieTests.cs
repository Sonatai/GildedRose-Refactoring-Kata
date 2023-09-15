using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using GildedRoseKata;
using NUnit.Framework;

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
        IList<Item> items = new List<Item>
        {
            new ()
            {
                Name = "Aged Brie", 
                SellIn = 11, 
                Quality = 41
            }
        };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Aged Brie");
        item.SellIn.Should().Be(10);
        item.Quality.Should().Be(42);
    } 
    
    [Test]
    public void UpdateBrieItem2()
    {
        //Arrange
        IList<Item> items = new List<Item>
        {
            new ()
            {
                Name = "Aged Brie", 
                SellIn = 11, 
                Quality = 50
            }
        };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Aged Brie");
        item.SellIn.Should().Be(10);
        item.Quality.Should().Be(50);
    } 
    
    [Test]
    public void UpdateBrieItem3()
    {
        //Arrange
        IList<Item> items = new List<Item>
        {
            new ()
            {
                Name = "Aged Brie", 
                SellIn = 0, 
                Quality = 41
            }
        };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Aged Brie");
        item.SellIn.Should().Be(-1);
        item.Quality.Should().Be(42);
    } 
}