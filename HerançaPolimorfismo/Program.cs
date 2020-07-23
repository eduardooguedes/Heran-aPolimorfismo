using System;
using System.Globalization;
using System.Collections.Generic;

namespace HerançaPolimorfismo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<Product> listProducts = new List<Product> ();

			Console.Write ("Enter the number of products: ");
			int n = int.Parse (Console.ReadLine ());

			for(int i = 0; i < n; i++)
			{
				Console.WriteLine ("Product #{0} data: ", i+1);
				Console.Write ("Commom, used or imported (c/u/i) ? ");
				char choice = char.Parse (Console.ReadLine ());
				Console.Write ("Name: ");
				string name = Console.ReadLine ();
				Console.Write ("Price: ");
				double price = double.Parse(Console.ReadLine (), CultureInfo.InvariantCulture);

				if(choice  == 'c' || choice == 'C')
				{
					listProducts.Add(new Product(name, price));
				}
				else
					if(choice == 'u' || choice == 'U')
					{
						Console.Write ("Manufacture date (DD/MM/YYYY): ");
						DateTime date = DateTime.Parse(Console.ReadLine());
						listProducts.Add(new UsedProduct(name, price, date));
					}
					else
					{
						Console.Write ("Customs fee: ");
						double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
						listProducts.Add(new ImportedProduct(name, price, customsFee));
					}
				Console.WriteLine ("-----------------");
			}

			Console.WriteLine ();
			Console.WriteLine ("PRICE TAGS:");
			foreach(Product product in listProducts)
			{
				Console.WriteLine (product.priceTag());
			}

			Console.ReadLine();
		}
	}
}
