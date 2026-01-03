using System;
using CafeteriaMenu;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        menu.DisplayMenu();

        Console.Write("Enter item index: ");
        int index = int.Parse(Console.ReadLine());

        FoodItems selectedItem = menu.GetItemByIndex(index);

        if (selectedItem == null){
            Console.WriteLine("Select something appropriate");
            return;
        }

        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        int x = selectedItem.GetPrice();
        double total = x * quantity;

        OrderItem order = new OrderItem(selectedItem, quantity);
        Console.WriteLine(selectedItem.GetName()+ "  X  " + quantity + " : Total "+ total + " JPY.");

      
    }
}
