﻿
// See https://aka.m    s/new-console-template for more information
namespace Assignment1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("STORE \n");

        try{
            Console.WriteLine("Do you have a loyalty card? (yes/no)");
            var loyalty = Console.ReadLine();
            

            Console.WriteLine("Available Grocery Items: \nApple - $1.00 \nBanana - $0.50 \nMilk - $2.50 \nBread - $2.00 \nEggs - $1.75 ");
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
            // if(apple > 0){
            //     receipt += $"Apple x{apple}\n";
            // }
            // else 
            // if(loyalty == "yes"){

            // }
            
            Console.WriteLine("\nReceipt:");
            Console.WriteLine($"Apple x{apple}\nApple x{apple}\nApple x{apple}\n");

            float subTotal = (float)(1.50*apple) + (float)(0.50*banana) + (float)(2.50*milk) + (float)(2.50*bread) + (float)(1.75*eggs);
            Console.WriteLine("Subtotal: $"+subTotal);

            float Taxof13 = subTotal * 0.13f;
            Console.WriteLine("Tax (13%): $"+Taxof13);

            float = (float) subTotal + Taxof13;
            Console.WriteLine("Total cost: $"+ );

        }
        catch(Exception e){
            Console.WriteLine("Invalid input");
        }
  

        
        
    }
}