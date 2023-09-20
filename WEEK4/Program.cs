// See https://aka.m    s/new-console-template for more information
namespace Week4;

// Class
class Car
{

    int speed = 0;
    string color = "Black";
    int numberOfKms = 0;

    string type = "Sport";

    public static int numberOfCarsCreated = 0;

    public string [] gears = {"1","2","3","4","5"};

    // Default Constructor
    public Car(){
        Console.WriteLine("Default Constructor: Sport mode");
        numberOfCarsCreated += 1;
    }    

    // Overloading Constructor
    public Car(string t){
        type = t;
        Console.WriteLine("Overloaded Constructor: casual mode");
        numberOfCarsCreated += 1;
    }

    // Methods
    public void accelerate(){
        speed += 1;

    }
    public void brake(){
        speed -= 1;
    }
    public int Speed(){
        return speed;
    }
    public string Color(){
        return color;
    }
    public void getNumberOfGears(){
        foreach(var i in gears)
        {
            Console.WriteLine(i);
        }
    }
}
class Program
{
   
    static void Main(string[] args)
    {
        Console.WriteLine("Class/ Default Constructor/ Overloading Constructor");
        
        // Reference
        Car c1 = new Car();

        Car mode = new Car("Casual");

        // Calling methods via reference
        c1.accelerate();
        c1.accelerate();
        c1.accelerate();
        c1.accelerate();

        c1.brake();
        Console.WriteLine("speed of cat: "+ c1.Speed() + "kmph");
        Console.WriteLine("color of cat: "+ c1.Color());
        Console.WriteLine("number of cars created: "+ Car.numberOfCarsCreated);

        // Arrays
        Console.WriteLine("\nArrays");
        c1.getNumberOfGears();


        // String Manipulation
        Console.WriteLine("\nString Manipulation");

        char c = '1';
        Console.WriteLine("Char: "+ c);
        Console.WriteLine("IsDigit: "+ char.IsDigit(c));
        Console.WriteLine("IsLetter: "+ char.IsLetter(c));
        Console.WriteLine("IsPunctuation: "+ char.IsPunctuation(c));
        Console.WriteLine("IsWhiteSpace: "+ char.IsWhiteSpace(c));
        Console.WriteLine("ToUpper: "+ char.ToUpper(c));
        Console.WriteLine("ToLower: "+ char.ToLower(c));
        


        string str = "yash.Mistry ";
        Console.WriteLine("\nString: "+ str);
        Console.WriteLine("IsDigit: "+ char.IsDigit(str,0));
        Console.WriteLine("IsLetter: "+ char.IsLetter(str,0));
        Console.WriteLine("Contains: "+ str.Contains("y"));
        Console.WriteLine("IndexOf: "+ str.IndexOf('s'));
        Console.WriteLine("StartsWith: "+ str.StartsWith("y"));
        Console.WriteLine("EndsWith: "+ str.EndsWith("y"));
        Console.WriteLine("SubString: "+ str.Substring(0,1));
        Console.WriteLine("Insert: "+ str.Insert(1, "h"));
        Console.WriteLine("Remove: "+ str.Remove(1));
        Console.WriteLine("Trim: "+ str.Trim());
        Console.WriteLine("TrimStart: "+ str.TrimStart());
        Console.WriteLine("TrimEnd: "+ str.TrimEnd());
        Console.WriteLine("Split: ");
        foreach (var item in str.Split("."))
        {
            Console.WriteLine(item);
        }



        // Console.WriteLine("EndsWith: "+ str.EndsWith(1,"y"));



    }
}