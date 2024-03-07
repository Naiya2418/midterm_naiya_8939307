using System.Xml.Linq;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
        Console.WriteLine($"price of {ItemName} updated to {Price}");
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"{additionalQuantity} {ItemName}(s) add to stock. total quantity now: {QuantityInStock}");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"{quantitySold} {ItemName}(s) sold. remaining quantity: {QuantityInStock}");
        }
        else
        {
            Console.WriteLine($"not enough {ItemName} in stock to sell {quantitySold}. available quantity: {QuantityInStock}");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"name: {ItemName}, id: {ItemId}, price: {Price}, quantity: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Initial Details:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();
        // 2. Sell some items and then print the updated details.
        Console.WriteLine("after selling 7 laptops and 7 Smartphones:");
        item1.SellItem(7);
        item2.SellItem(7);
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();
        // 3. Restock an item and print the updated details.
        Console.WriteLine("after restocking 13 Smartphones:");
        item2.RestockItem(13);
        item2.PrintDetails();
        Console.WriteLine();
        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine($"Is {item1.ItemName} in stock? {item1.IsInStock()}");
        Console.WriteLine($"Is {item2.ItemName} in stock? {item2.IsInStock()}");


    }
}