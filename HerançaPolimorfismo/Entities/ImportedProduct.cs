using System;
using System.Globalization;

namespace HerançaPolimorfismo
{
	class ImportedProduct : Product
	{
		public double CustomsFee { get; set; }

		public ImportedProduct (string name, double price, double customsFee)
			: base (name, price)
		{
			CustomsFee = customsFee;
		}

		public override string priceTag ()
		{
			return Name + " $" + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
		}

		public double totalPrice()
		{
			return Price + CustomsFee;
		}
	}
}

