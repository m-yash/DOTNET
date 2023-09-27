// Calculator
namespace Week3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CALCULATOR \n");

        try{
            Console.WriteLine("Enter number 1");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            int y = int.Parse(Console.ReadLine());

            // Console.WriteLine($"Addition:{x+y}   Subtraction:{x-y}   Multiplication:{x*y}   Division:{x/y}");
            
            Console.WriteLine("\n");
            Console.WriteLine("Enter 1.Addition 2.Subtraction 3.Multiplication 4.Division");
            int z = int.Parse(Console.ReadLine());

            if(z == 1){
                Console.WriteLine(x+y);
            }
            else if(z == 2){
                Console.WriteLine(x-y);
            }
            else if(z == 3){
                Console.WriteLine(x*y);
            }
            else {
                Console.WriteLine(x/y);
            }

        }
        catch(Exception e){
            Console.WriteLine("Invalid input");
        }
  

        
        
    }
}