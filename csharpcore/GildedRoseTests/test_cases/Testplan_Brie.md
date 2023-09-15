Testplan für Brie

"Normal Item" = no special item
"Brie" = "Aged Brie"
"Backstage" = "Backstage passes to a TAFKAL80ETC concert"
"Sulfuras" = "Sulfuras, Hand of Ragnaros"

TC 1: Brie get updated with SellIn = 11 and Quality = 41
    1) Item initialize with
        Name : Aged Brie
        SellIn : 11
        Quality : 41
    2) Update item
    3) Expected:
        Name : Aged Brie
        SellIn : 10
        Quality : 42

TC 2: Brie get updated with SellIn = 11 and Quality = 50
    1) Item initialize with
        Name : Aged Brie
        SellIn : 11
        Quality : 50
    2) Update item
    3) Expected:
        Name : Aged Brie
        SellIn : 10
        Quality : 50

TC 3: Brie get updated with SellIn = 0 and Quality = 41
    1) Item initialize with
        Name : Aged Brie
        SellIn : 11
        Quality : 41
    2) Update item
    3) Expected:
        Name : Aged Brie
        SellIn : -1
        Quality : 42