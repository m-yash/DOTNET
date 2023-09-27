// basic
// User input
// Operator
// Type casting
// Exception handling

// // See https://aka.m    s/new-console-template for more information
// namespace Week1;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // basic
//         Console.WriteLine("hello");
//         int a = 20;
//         Console.WriteLine("int: "+ a);

//         string b = "yash";
//         Console.WriteLine("string: "+ b);
        
//         float c = 3.14f;
//         Console.WriteLine("float: "+ c);

//         var d = 1;
//         Console.WriteLine("var: "+ d);

//         // operator
//         Console.WriteLine("\n");
//         Console.WriteLine($"{10+5} {10-5}");

//         // user input
//         Console.WriteLine("\n");
//         Console.WriteLine("Enter value");
//         var e = Console.ReadLine();
//         Console.WriteLine(e);

//         // type casting (may be)
//         Console.WriteLine("\n");
//         var f = 2;
//         Console.WriteLine($"{f.ToString().GetType()} {f.GetType()}");

//         // exception handling
//         Console.WriteLine("\n");
//         try{
//             var g = "g";
//         }
//         catch(Exception e)
//         {
//             Console.WriteLine("Error: "+ e.Message);
//         }
        

//     }
// }

// See https://aka.m    s/new-console-template for more information
namespace Week1;

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