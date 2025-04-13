// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace test {

class Program
{
    static void Main(string[] args)
    {
        // var sale = new SaleWithTax(500, 50m);
	// var message = sale.GetInfo();
	var sale = new SaleOnline(10.75m, 2.25m);
	var getSale = sale.GetInfo();
	Console.WriteLine(getSale);
	//Console.WriteLine(message);
	

    }
}


}
