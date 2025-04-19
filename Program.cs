
namespace test;

class Program
{
    static void Main(string[] args)
    {

	// var sale = new SaleOnSite(10.75m, 2.25m);
	// // var sale = new SaleOnline(10.75m, 2.25m);
	// var getSale = sale.GetInfo();
	// Console.WriteLine(getSale);
	var numbers2 = new MyList<int>(5);
	var numbers = new List<int>(6);
	numbers.Add(0);
	numbers.Add(1);
	numbers.Add(2);
	numbers.Add(3);
	numbers.Add(4);
	numbers.Add(5);

	// Console.WriteLine(numbers.GetContent());
	// Console.WriteLine(numbers);
	numbers.ForEach(num => Console.WriteLine(num));
    }
}


