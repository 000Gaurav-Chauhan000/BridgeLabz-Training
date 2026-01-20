namespace OnlineMarketplace
{
    public class DiscountService
    {
        public void ApplyDiscountAlgo<T>(T product, double percentage)
            where T : Product<object>
        {
            product.Price -= product.Price * (percentage / 100);
        }
    }
}
