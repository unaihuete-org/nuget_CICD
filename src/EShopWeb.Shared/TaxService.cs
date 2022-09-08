namespace EShopWeb.Shared;
public class TaxService
{
    static public decimal CalculateTax(decimal taxable, string postalCode)
    {
        // COMMENT change for CI testing
        return taxable * (decimal).1;
    }

}
