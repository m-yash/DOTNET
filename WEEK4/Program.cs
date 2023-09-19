// See https://aka.m    s/new-console-template for more information
namespace Week4;

class Car
{

    int speed = 0;
    string color = "Black";
    int numberOfKms = 0;

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
        c1.accelerate();
        c1.accelerate();
        c1.accelerate();
        c1.accelerate();

        c1.brake();
        Console.WriteLine(c1.Speed());

        Console.WriteLine(c1.Color());

        
    }
}