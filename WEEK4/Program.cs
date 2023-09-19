// See https://aka.m    s/new-console-template for more information
namespace Week4;

class Car
{

    int speed = 0;
    string color = "Black";
    int numberOfKms = 0;

    string type = "Sport";

    public static int numberOfCarsCreated = 0;
    public Car(){
        Console.WriteLine("Default Constructor: Sport mode");
        numberOfCarsCreated += 1;
    }    
    public Car(string t){
        type = t;
        Console.WriteLine("Overloaded Constructor: casual mode");
        numberOfCarsCreated += 1;
    }
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
}
class Program
{
   
    static void Main(string[] args)
    {
        Console.WriteLine("Car");
        
        Car c1 = new Car();

        Car mode = new Car("Casual");

        
        c1.accelerate();
        c1.accelerate();
        c1.accelerate();
        c1.accelerate();

        c1.brake();
        Console.WriteLine("speed of cat: "+ c1.Speed() + "kmph");

        Console.WriteLine("color of cat: "+ c1.Color());

        Console.WriteLine("number of cars created: "+ Car.numberOfCarsCreated);
        
    }
}