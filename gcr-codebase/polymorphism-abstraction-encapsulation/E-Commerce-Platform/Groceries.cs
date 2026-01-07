using E_Commerce_Platform;

namespace E_Commerce_Platform
{
    public class Groceries : Product
    {
        public Groceries(int id, string name, decimal price)
            : base(id, name, price)
        {
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.05m; 
        }
    }
}
