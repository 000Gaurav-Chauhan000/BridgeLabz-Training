using E_Commerce_Platform;

namespace E_Commerce_Platform
{
    public class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, decimal price)
            : base(id, name, price)
        {
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.10m; 
        }

        public decimal CalculateTax()
        {
            return Price * 0.18m; 
        }

        public string GetTaxDetails()
        {
            return "18% GST on Electronics";
        }
    }
}
