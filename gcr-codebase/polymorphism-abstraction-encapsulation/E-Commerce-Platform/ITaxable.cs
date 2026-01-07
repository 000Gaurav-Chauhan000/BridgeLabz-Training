namespace E_Commerce_Platform
{
    public interface ITaxable
    {
        decimal CalculateTax();
        string GetTaxDetails();
    }
}
