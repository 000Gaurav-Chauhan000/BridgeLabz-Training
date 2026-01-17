using System;
namespace FlashDealz
{
    class ProductUtility
{
    public void QuickSortAlgo(List<Products> products, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(products, low, high);
            QuickSortAlgo(products, low, pivotIndex - 1);
            QuickSortAlgo(products, pivotIndex + 1, high);
        }
    }

    private int Partition(List<Products> products, int low, int high)
    {
        double pivot = products[high].Discount;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (products[j].Discount > pivot) // higher discount first
            {
                i++;
                Swap(products, i, j);
            }
        }

        Swap(products, i + 1, high);
        return i + 1;
    }

    private void Swap(List<Products> products, int i, int j)
    {
        Products temp = products[i];
        products[i] = products[j];
        products[j] = temp;
    }

    public void DisplayProducts(List<Products> products)
    {
        foreach (var p in products)
        {
            Console.WriteLine($"{p.ProductName} | Discount: {p.Discount}% | Price: {p.ProductPrice}");
        }
    }
}

}