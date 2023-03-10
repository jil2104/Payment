using System;


// Class for Information about Items
class ItemInfo
{
	// Initialize the ItemInfo Class variables
	public int NumberofItems;
	public double price;
	public double discount;

	// Method to Get Data Member Values
	public void GetInfo(int NoItem, double Pr, double Disc)
	{
		//Console.WriteLine("ItemName is:", itemName);

		NumberofItems = NoItem; // Assigning Value to NumberofItems
		Console.WriteLine("Number of Items in Cart is:{0}", NumberofItems);

		price = Pr;             // Assigning Value to Price
		Console.WriteLine("Price of Item is:{0}", price);
		
		discount = Disc;        // Assigning Value to Discount
		Console.WriteLine("Discount Amount is:{0}", discount);
		
	}
	
}

// Payment Class to Display Total and  and InteInfo, Inherited from ItemInfo
class Payment : ItemInfo
{
	public double total;

	// Calculating the total
	public void DisplayTotal()
	{
		total = (NumberofItems * price) * (1 - (discount / 100)); // Deducting Dicsount from Totals
		Console.WriteLine("Total is:{0}", total);
	}

	public static void Main(string[] args)
	{
		Payment payment = new Payment(); // Creating the Object for Payment Class
		payment.GetInfo(5, 10, 5);      // Calling the GetInfo Method using payment object
		payment.DisplayTotal();			// Calling the DisplayTotal Method using payment object

		Console.WriteLine("Cash Payment is Accepted !!"); // Printing that Cash Payment is Accepted

	}
}

