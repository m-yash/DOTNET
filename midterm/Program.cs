// See https://aka.m    s/new-console-template for more information
namespace midterm;


class Program
{
    static void Main(string[] args)
    {
        // Displaying Book Store Details
        Book b = new Book();
        b.DisplayBookStoreDetails();

        bool looper = true;

        // Item List
        Item itemdata = new Item();

        // Hardcore Data
        itemdata.AddItem("Republic of US", 3, 14.32);
        itemdata.AddItem("Anna Frank", 10, 14.99);
        itemdata.AddItem("King of Charles", 7, 7.32);

        while (looper)
        {

            Console.WriteLine("Choose an option below:\n1.Add a new Item to the inventory\n2.Display all books\n3.Delete an individual item from the inventory\n4.Clear Inventory\n5.Exit the program.");
            var path = int.Parse(Console.ReadLine() ?? string.Empty);

            // when 1 entered
            if (path == 1)
            {
                // Exception Handling
                try
                {
                    Console.WriteLine("Enter Book Name");
                    string BookNameInput = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Enter Quantity in Stock:");
                    int BookQtyInStockInput = int.Parse(Console.ReadLine() ?? string.Empty);

                    Console.WriteLine("Enter Price per unit");
                    double BookPricePerUnitInput = double.Parse(Console.ReadLine() ?? string.Empty);

                    itemdata.AddItem(BookNameInput, BookQtyInStockInput, BookPricePerUnitInput);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else if (path == 2)
            {
                // display
                itemdata.DisplayAllInventory();
            }
            else if (path == 3)
            {
                // Remove Specific Item
                itemdata.DisplayAllInventory();
                Console.WriteLine("\nWhich Item do you want to remove?\nWe suggest to refer Item Number by displaying all the items first");
                int RmAt = int.Parse(Console.ReadLine() ?? string.Empty);
                itemdata.ClearIndividualItemFromInventory(RmAt);
                Console.Write("Item Removed Successfully!\n");
            }
            else if (path == 4)
            {
                // Clear All
                itemdata.ClearAllInventory();
                Console.Write("Whole Inventory Cleared Successfully!\n");
            }
            else if (path == 5)
            {
                // Exit
                looper = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }


    class Book
    {
        public void DisplayBookStoreDetails()
        {
            List<string> MyStore = new List<string>();

            // String Concatenation for first and last name
            string FirstName = "Yash ";
            string LastName = "Mistry";
            string Fullname = FirstName + LastName;
            MyStore.Add("MyBookStore"); MyStore.Add(Fullname); MyStore.Add("SUNVIEW ST, WATERLOO, ON");
            Console.WriteLine($"Store Name: {MyStore.ElementAt(0)}\nOwner: {MyStore.ElementAt(1)}\nStore Address: {MyStore.ElementAt(2)}\n");
        }
    }


    // Class for inheritance Usage
    public class ItemName
    {
        public string Name { get; set; }

        public ItemName(string name)
        {
            Name = name;
        }
    }

    // Inheritance Usage
    public class ItemDetails : ItemName
    {
        // public string BookName {get; set;}
        public int BookQuantity { get; set; }

        public double BookPrice { get; set; }

        public ItemDetails(string name, int qty, double price) : base(name)
        {
            // BookName = name;
            BookQuantity = qty;
            BookPrice = price;
        }
    }

    // Interface 
    public interface Itemable
    {
        void ClearAllInventory();
        void ClearIndividualItemFromInventory(int RmAt);

        void DisplayAllInventory();
    }

    // Implementing Interface
    public class Item : Itemable
    {
        public List<ItemDetails> InvetoryItem = new List<ItemDetails>();

        public void AddItem(string name, int BookQtyInStockInput, double BookPricePerUnitInput)
        {
            InvetoryItem.Add(new ItemDetails(name, BookQtyInStockInput, BookPricePerUnitInput));
        }

        public void ClearAllInventory()
        {
            InvetoryItem.Clear();
            Console.WriteLine("Whole Inventory is cleared!\n");
        }

        public void DisplayAllInventory()
        {
            int cnt = 0;
            double QuantityTotal = 0;
            double PricePerUnitTotal = 0;
            foreach (ItemDetails i in InvetoryItem)
            {
                try
                {
                    Console.WriteLine($"\nItem Number: {cnt} \nBook Name : {i.Name}\nBook in Stock: {i.BookQuantity}\nBook Price per unit: ${i.BookPrice}");
                    cnt++;

                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong! Exit the system and come back\n");
                    break;
                }

            }
            foreach (ItemDetails itotal in InvetoryItem)
            {
                QuantityTotal += itotal.BookQuantity;
                PricePerUnitTotal += itotal.BookPrice;
            }
            Console.WriteLine($"\nTotal Value of the Entire Inventory: ${QuantityTotal * PricePerUnitTotal}\n");
        }
        public void ClearIndividualItemFromInventory(int RmAt)
        {
            InvetoryItem.RemoveAt(RmAt);
        }
    }

}
