// See https://aka.m    s/new-console-template for more information
namespace Assignment1;

class Program
{
    static void Main(string[] args)
    {
        bool looper = true;

        while (looper)
        {
            Console.WriteLine("Do you have a loyalty card? (yes/no)");
            string loyalty = Console.ReadLine();

            if (loyalty == "yes" || loyalty == "no")
            {
                try
                {
                    Console.WriteLine("\nAvailable Grocery Items: \nApple - $1.00 \nBanana - $0.50 \nMilk - $2.50 \nBread - $2.00 \nEggs - $1.75\n");
                    Console.WriteLine("Enter the quantity of Apple (0 for none)");
                    int apple = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity of Banana (0 for none)");
                    int banana = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity of Milk (0 for none)");
                    int milk = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity of Bread (0 for none)");
                    int bread = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity of Eggs (0 for none)");
                    int eggs = int.Parse(Console.ReadLine());

                    string receipt = "";

                    if (apple > 0)
                    {
                        receipt += $"Apple x{apple}\n";
                    }
                    if (banana > 0)
                    {
                        receipt += $"Banana x{banana}\n";
                    }
                    if (milk > 0)
                    {
                        receipt += $"Milk x{milk}\n";
                    }
                    if (bread > 0)
                    {
                        receipt += $"Bread x{bread}\n";
                    }
                    if (eggs > 0)
                    {
                        receipt += $"Eggs x{eggs}\n";
                    }

                    Console.WriteLine("\nReceipt:");
                    Console.WriteLine(receipt);

                    // float subTotal = (float)(1.50*apple) + (float)(0.50*banana) + (float)(2.50*milk) + (float)(2.50*bread) + (float)(1.75*eggs);
                    // float subTotal = 1.50f *apple + 0.50f *banana + 2.50f*milk + 2.50f*bread + 1.75f*eggs;
                    double subTotal = 1.50 * apple + 0.50 * banana + 2.50 * milk + 2.50 * bread + 1.75 * eggs;

                    if (loyalty == "yes")
                    {
                        double tenPercentOfSubTotal = subTotal * 0.10;

                        double discountedSubTotal = subTotal - tenPercentOfSubTotal;
                        Console.WriteLine("Subtotal: $" + discountedSubTotal);

                        double Taxof13 = discountedSubTotal * 0.13;
                        Console.WriteLine("Tax (13%): $" + Taxof13);

                        double totalAfterTax = subTotal + Taxof13;
                        Console.WriteLine("Total cost: $" + totalAfterTax);
                        
                        looper = false;
                    }
                    else if (loyalty == "no")
                    {
                        Console.WriteLine("Subtotal: $" + subTotal);

                        double Taxof13 = subTotal * 0.13;
                        Console.WriteLine("Tax (13%): $" + Taxof13);

                        double totalAfterTax = subTotal + Taxof13;
                        Console.WriteLine("Total cost: $" + totalAfterTax);

                        looper = false;
                    }
                    else
                    {
                        Console.WriteLine("Unknown error!\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Quantity of item should be in numbers!\n");
                }
            }
            else
            {
                Console.WriteLine("Enter yes or no for loyalty check!\n");
            }
        }
    }
}