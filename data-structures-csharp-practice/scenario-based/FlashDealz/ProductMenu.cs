using System;
 namespace FlashDealz{
    class ProductMenu
    {
        public void ShowMenu()
        {
            ProductUtility utility = new ProductUtility();

            List<Products> products = new List<Products>
        {
            new Products("Laptop", 101, 60000, 30),
            new Products("Phone", 102, 40000, 20),
            new Products("Headphones", 103, 5000, 50),
            new Products("Camera", 104, 45000, 10)
        };

            Console.WriteLine("Top Discounted Products (Before Sorting)");
            utility.DisplayProducts(products);

            utility.QuickSortAlgo(products, 0, products.Count - 1);

            Console.WriteLine("\nTop Discounted Products (After Quick Sort)");
            utility.DisplayProducts(products);
        }
    }
}