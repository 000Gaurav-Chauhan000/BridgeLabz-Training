using System;

namespace CafeteriaMenu{
    internal class Menu{
        
        FoodItems[] foodItems = {
            new FoodItems("Sashimi", 500),
            new FoodItems("Takoyaki", 300),
            new FoodItems("Udon", 400),
            new FoodItems("Oden", 350),
            new FoodItems("YakiSoba", 450),
            new FoodItems("Ramen", 550),
            new FoodItems("Curry Rice", 600),
            new FoodItems("Sushi", 700),
            new FoodItems("Toriyaki", 500),
            new FoodItems("Osechi Ryori", 800),
            new FoodItems("Okonomiyaki", 400),
            new FoodItems("Sukiyaki", 750),
            new FoodItems("Onigiri", 200)
        };
        public void DisplayMenu(){           
            for(int i = 0; i < foodItems.Length; i++){
                Console.WriteLine($"{i}.{foodItems[i].GetName()} - {foodItems[i].GetPrice()} JPY");
            }
        }
        public FoodItems GetItemByIndex(int index){
            if (index >= 0 && index < foodItems.Length){
                return foodItems[index];
            }
            return null;
        }
    }
}