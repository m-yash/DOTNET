// If else
// Switch
// Enums
// While
// Do while

namespace Week2;

class Program
{

        enum points{
            one,two,three,four
        }

    static void Main(string[] args)
    {
        // boolean
        // int a = 10;
        // int b = 12;
        // bool c = a < b ;
        // Console.WriteLine(c);

        // // If else statement
        // if (a > b && a == b)
        // {
        //     Console.WriteLine("A greater than b");
        // }
        // else
        // {
        //     Console.WriteLine("B greater than a");
        // }

        // Switch
        // Console.WriteLine("Enter a number 1 2 3");
        // var choicee = int.Parse(Console.ReadLine());
        // switch (choicee)
        // {
        //     case 1:
        //         Console.WriteLine("1..");
        //         break;
        //     case 2:
        //         Console.WriteLine("2..");
        //         break;
        //     case 3:
        //         Console.WriteLine("3..");
        //         break;                                                
        //     default:
        //         Console.WriteLine("invalid input");
        //         break;
        // }

        // Excercise
        // Console.WriteLine("Enter your grade (0 to 100)");
        // var choice = int.Parse(Console.ReadLine());
        // if(choice >= 80){
        //     Console.WriteLine("grade a");
        // }
        // else if(choice < 80 && choice >= 60 ){
        //     Console.WriteLine("grade b");
        // }
        // else if(choice < 60 && choice >= 40){
        //     Console.WriteLine("grade c");
        // }
        // else if(choice < 40){
        //     Console.WriteLine("grade d");
        // }
        // else{
        //     Console.WriteLine("invalid input");
        // }

        // for loop
        LOOPS();

    }
    static void LOOPS()
    {
        // Console.WriteLine("for loop");
        // for (int i = 0; i < 3; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // // while loop
        // Console.WriteLine("\nWhile loop");
        // int j = 0;
        // while (j < 3)
        // {
        //     Console.WriteLine(j);
        //     j++;
        // }

        // // do while
        // int k = 0;
        // Console.WriteLine("\ndo while");
        // do
        // {
        //     Console.WriteLine(k);
        //     k++;
        // } while (k < 3);


        // // Infinite loop
        // Console.WriteLine("\ninfinite loop");
        // Console.WriteLine("Enter Number");
        // int l = int.Parse(Console.ReadLine());
        // bool t = true;
        // while (t)
        // {
        //     if (l == 1)
        //     {
        //         Console.WriteLine("\nok");
        //     }
        //     else
        //     {
        //         t = false;
        //     }

        // }

        // enums
        Console.WriteLine("\nEnum");
        Console.WriteLine((int)points.four);

        foreach (points p in Enum.GetValues(typeof(points)))
        {
            Console.WriteLine(p + " " + (int)p);
            
        }

        // ok

        // Excercise Prime number
        // do
        // {
        //     Console.WriteLine("Number:");
        //     var num = int.Parse(Console.ReadLine());
        //     if(num%2 == 0){
        //         Console.WriteLine("not a prime");
        //         Console.WriteLine("\n");
        //     }
        //     else{
        //         Console.WriteLine("Prime");
        //         Console.WriteLine("\n");
        //     }
        // } while (true);
        
        // Console.WriteLine("Number:");
        // var num = int.Parse(Console.ReadLine());
        // int primes = 0;

        // do
        // { 
        //     if(primes == num){
        //         break;
        //     }
        //     else if(primes%2 == 0){
        //         // Console.WriteLine("not a prime");
        //         // Console.WriteLine("\n");
        //         primes++;
        //     }
        //     else{
        //         Console.WriteLine(primes);  
        //         primes++;
        //     }
        // } while (true);


        // if(num%2 == 0){
        //     Console.WriteLine("not a prime");
        // }
        // else{
        //     Console.WriteLine("Prime");
        // }

        
    }
}
