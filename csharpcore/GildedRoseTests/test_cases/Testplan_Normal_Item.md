Testplan für Normal Item

"Normal Item" = no special item
"Brie" = "Aged Brie"
"Backstage" = "Backstage passes to a TAFKAL80ETC concert"
"Sulfuras" = "Sulfuras, Hand of Ragnaros"

TC 1: Normal Item get updated but SellIn > 0 & Quality = 43
    1) Item initialize with
        Name : Great Platypus (Pet)
        SellIn : 30
        Quality : 43
    2) Update item
    3) Expected:
        Name : Great Platypus (Pet)
        SellIn : 29
        Quality : 42

TC 2: Normal Item get updated but SellIn = 1 & Quality = 44
    1) Item initialize with
        Name : Great Platypus (Pet)
        SellIn : 1
        Quality : 44
    2) Update item
    3) Expected:
        Name : Great Platypus (Pet)
        SellIn : 0
        Quality : 42

TC 3: Normal Item get updated but SellIn = 0 & Quality = 44
    1) Item initialize with
        Name : Great Platypus (Pet)
        SellIn : 0
        Quality : 44
    2) Update item
    3) Expected:
        Name : Great Platypus (Pet)
        SellIn : -1
        Quality : 42

TC 4: Normal Item get updated but SellIn = 30 && Quality = 0
    1) Item initialize with
        Name : Great Platypus (Pet)
        SellIn : 30
        Quality : 0
    2) Update item
    3) Expected:
        Name : Great Platypus (Pet)
        SellIn : 29
        Quality : 0

TC 5: Normal Item get updated but SellIn = 1 & Quality = 0
    1) Item initialize with
        Name : Great Platypus (Pet)
        SellIn : 1
        Quality : 0
    2) Update item
    3) Expected:
        Name : Great Platypus (Pet)
        SellIn : 0
        Quality : 0