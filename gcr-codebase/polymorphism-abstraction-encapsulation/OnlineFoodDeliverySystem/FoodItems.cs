using System;

namespace CafeteriaMenu{
    internal class FoodItems{
        string name;
        int price;

        public FoodItems(string name, int price){
            this.name = name;
            this.price = price;
        }
        public string GetName(){
            return name;
        }
        public int GetPrice(){
            return price;
        }
    }
}
