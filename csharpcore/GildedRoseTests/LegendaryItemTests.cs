using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using GildedRoseKata;
using NUnit.Framework;

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
        IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 30, Quality = 44 } };
        var app = new GildedRose(items);
        
        //Act
        app.UpdateQuality();
        
        //Assert
        var item = items.First();
        item.Name.Should().Be("Sulfuras, Hand of Ragnaros");
        item.Quality.Should().Be(44);
        item.SellIn.Should().Be(30);
    }
}