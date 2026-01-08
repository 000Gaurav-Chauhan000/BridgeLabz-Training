using System;
namespace CafeteriaMenu{
    internal class OrderItem{

        FoodItems foodItem;
        int quantity;

        public OrderItem(FoodItems FoodItem, int Quantity) {
            foodItem = FoodItem;
            quantity = Quantity;
        }
        public int Quantity {
            get; private set;
        }
        public FoodItems item => foodItem;
    }
}
