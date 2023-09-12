namespace Week2;

class Program
{
    static void Main(string[] args)
    {
        // boolean
        int a = 10;
        int b = 12;
        bool c = a < b ;
        Console.WriteLine(c);

        // If else statement
        if (a > b && a == b)
        {
            Console.WriteLine("A greater than b");
        }
        else
        {
            Console.WriteLine("B greater than a");
        }

        // Switch
        Console.WriteLine("Enter a number 1 2 3");
        var choicee = int.Parse(Console.ReadLine());
        switch (choicee)
        {
            case 1:
                Console.WriteLine("1..");
                break;
            case 2:
                Console.WriteLine("2..");
                break;
            case 3:
                Console.WriteLine("3..");
                break;                                                
            default:
                Console.WriteLine("invalid input");
                break;
        }

        // Excercise
        Console.WriteLine("Enter your grade (0 to 100)");
        var choice = int.Parse(Console.ReadLine());
        if(choice >= 80){
            Console.WriteLine("grade a");
        }
        else if(choice < 80 && choice >= 60 ){
            Console.WriteLine("grade b");
        }
        else if(choice < 60 && choice >= 40){
            Console.WriteLine("grade c");
        }
        else if(choice < 40){
            Console.WriteLine("grade d");
        }
        else{
            Console.WriteLine("invalid input");
        }

    }
}
