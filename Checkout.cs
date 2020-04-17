using System;
using System.Collections.Generic;

namespace practise
{
    class Items
	{
		private double _price, _quantity;
		
		public double quantity { get {return _price;} set{_price = value;} }
		
		public double price { get {return _quantity;} set{_quantity = value;} }
	}
	class Checkout
	{
		public List<Items> itemList = new List<Items>();
		
		
		
		public double taxCalculator(double total)
		{
			var taxRate = 0.33;
			return taxRate * total;
			
		}
		
		
	}
    class CheckoutMachine
    {
        public void _checkout() 
        {
            bool again = true;
		Checkout _checkout = new Checkout();
		double totalPrice = 0;
		double convertedPrice, convertedQuantity;
		do
		{
			Items _items = new Items();
			Console.WriteLine("What is the price of the item?");
			bool priceConvert = double.TryParse(Console.ReadLine(), out convertedPrice);
			if (priceConvert)
				_items.price = convertedPrice;
			else
			{
				Console.WriteLine("Invalid input, please try again!");
				break;
			}
			
			Console.WriteLine("What is the quantity of the item?");
			bool quantityConvert = double.TryParse(Console.ReadLine(), out convertedQuantity);
			if (priceConvert)
				_items.quantity = convertedQuantity;
			else
			{
				Console.WriteLine("Invalid input, please try again!");
				break;
			}
			Console.WriteLine("aaaaaaaaaaaaa"+_items.price);
			
			Console.WriteLine("More items?  y/n");
			var check = Console.ReadLine();
			if ( check== "y")
			{
				_checkout.itemList.Add(_items);
				continue;
			}
			else if( check== "n")
			{
				again = false;
				_checkout.itemList.Add(_items);
			}
			else
				Console.WriteLine("Invalid inpute, please try again!");
			
			
		}while(again);
		foreach (var i in _checkout.itemList)
		{
			totalPrice += i.price * i.quantity;
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Price : "+i.price);
			Console.WriteLine("Quantity : "+i.quantity);
			Console.WriteLine("----------------------------------------------------");
			
		}
		Console.WriteLine("***********************************");
		Console.WriteLine("******	Total: $"+totalPrice	);
		Console.WriteLine("******	Tax: $" + _checkout.taxCalculator(totalPrice)		);
		Console.WriteLine("***********************************");
         }
    }
}