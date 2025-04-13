
namespace test
{

    class SaleOnSite : ISale {
	public decimal Total { get; set; }
	public decimal Tax { get; set; }

	public SaleOnSite(decimal total, decimal tax)
	{
            Total = total;
            Tax = tax;

        }
        public string GetInfo()
	{
            var subTotal = Total - Tax;
            return "\nVenta OnSite:"
		+ "\nSubtotal: " + Total
		+ "\nTax:" + Tax
		+ "\nTotal: " + Total;
        }
    }

    class SaleOnline : ISale {
	public decimal Total { get; set; }
	public decimal Tax { get; set; }
	public SaleOnline(decimal total, decimal tax)
	{
            Total = total;
            Tax = tax;

        }
        public string GetInfo()
	{
            var subTotal = Total - Tax;
            return "\nVenta OnLine:\nSubtotal: " + Total
		+ "\nTax:" + Tax
		+ "\nTotal: " + subTotal;
        }
    }

    class SaleWithTax : Sale
    {
        public decimal Tax { get; set; }

        public SaleWithTax(decimal total, decimal tax) : base(total)
        {
            Tax = tax;
        }

        public override string GetInfo()
        {
            return "El total es: " + Total + ", el impuesto es: " + Tax;
        }
    }

    class Sale
    {
        public decimal Total { get; set; }

        public Sale(decimal total)
        {
            Total = total;
        }
        public virtual string GetInfo()
        {
            return "El total es: " + Total;
        }
    }
}
