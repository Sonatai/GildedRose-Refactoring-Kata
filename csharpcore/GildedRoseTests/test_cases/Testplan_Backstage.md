Testplan für Backstage

"Normal Item" = no special item
"Brie" = "Aged Brie"
"Backstage" = "Backstage passes to a TAFKAL80ETC concert"
"Sulfuras" = "Sulfuras, Hand of Ragnaros"

TC 1: Backstage get updated with SellIn = 11 and Quality = 41
    1) Item initialize with
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 11
        Quality : 41
    2) Update item
    3) Expected:
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 10
        Quality : 42

TC 2: Backstage get updated with SellIn = 6 and Quality = 41
    1) Item initialize with
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 6
        Quality : 41
    2) Update item
    3) Expected:
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 5
        Quality : 43

TC 3: Backstage get updated with SellIn = 5 and Quality = 41
    1) Item initialize with
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 5
        Quality : 41
    2) Update item
    3) Expected:
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 4
        Quality : 44

TC 4: Backstage get updated with SellIn = 0 and Quality = 41
    1) Item initialize with
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 0
        Quality : 41
    2) Update item
    3) Expected:
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : -1
        Quality : 0

TC 5: Backstage get updated with SellIn = 11 and Quality = 50
    1) Item initialize with
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 11
        Quality : 50
    2) Update item
    3) Expected:
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 10
        Quality : 50

TC 6: Backstage get updated with SellIn = 6 and Quality = 50
    1) Item initialize with
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 6
        Quality : 50
    2) Update item
    3) Expected:
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 5
        Quality : 50

TC 7: Backstage get updated with SellIn = 5 and Quality = 50
    1) Item initialize with
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 5
        Quality : 50
    2) Update item
    3) Expected:
        Name : Backstage passes to a TAFKAL80ETC concert
        SellIn : 4
        Quality : 50