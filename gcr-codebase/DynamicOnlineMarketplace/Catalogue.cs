namespace OnlineMarketplace
{
    public class Catalog<T> where T : ProductBase
    {
        private List<T> products = new List<T>();

        public void AddProduct(T product)
        {
            products.Add(product);
        }

        public void DisplayAll()
        {
            foreach (var product in products)
            {
                product.Display();
            }
        }
    }
}
