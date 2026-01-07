using E_Commerce_Platform;

namespace E_Commerce_Platform
{
    public class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, decimal price)
            : base(id, name, price)
        {
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.20m; 
        }

        public decimal CalculateTax()
        {
            return Price * 0.12m; 
        }

        public string GetTaxDetails()
        {
            return "12% GST on Clothing";
        }
    }
}
