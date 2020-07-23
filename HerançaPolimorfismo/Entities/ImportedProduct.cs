using System;

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

		public override void priceTag ()
		{
			base.priceTag () + " (Customs fee: $" + CustomsFee + ")";
		}

	}
}

