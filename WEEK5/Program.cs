// Inheritance, Method Overloading/ Overriding, Polymorphism

namespace Week5;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("ZOOOOOOOOOOO \n");
        Console.WriteLine("VECCHILE \n");


        // Console.WriteLine("Parent Class");
        // Animal a = new Animal("animal", true, 800);

        // a.breathe();
        // a.eat();
        // a.eat("veggies");
        // a.sleep();

        // Console.WriteLine("\nSub Class extending Parent Class");
        // Cat c = new Cat("home", true, 5000);

        // c.breathe();
        // c.eat();
        // c.sleep();

        // Console.WriteLine("\nDetails of Cat");
        // Console.WriteLine($"{c.species} {c.isAlive} {c.price}");

        Console.WriteLine("Vechile");
        Vehicle v = new Vehicle("Unknown");
        v.Origin();

        Console.WriteLine("\nCar");
        Car carr = new Car("Sport");
        carr.Origin();
        carr.Origin("Brazil");

        Console.WriteLine("Type: " + carr.type);

        Console.WriteLine("\nBike");
        Bike bi = new Bike("Casual");
        bi.Origin();
        bi.Origin("Africa");

        Console.WriteLine("Type: " + bi.type);


    }
    class Animal
    {

        // Constructor
        public Animal(string _species, bool _isAlive, int _price)
        {
            species = _species;
            isAlive = _isAlive;
            price = _price;
        }
        public string species;

        public bool isAlive;

        public int price;


        public void breathe()
        {
            Console.WriteLine("Animal is breathing (good to sell)");
        }

        public void eat()
        {
            Console.WriteLine("Animal is eating (good to sell)");
        }

        // Method Overloading
        public void eat(string food)
        {
            Console.WriteLine($"Animal is eating {food} (good to sell)");
        }

        // Overriding
        public virtual void sleep()
        {
            Console.WriteLine("Animal is sleeping (sell)");
        }
    }

    class Cat : Animal
    {
        public Cat(string _species, bool _isAlive, int _price) : base(_species, _isAlive, _price)
        {
            species = _species;
            isAlive = _isAlive;
            price = _price;
        }

        // Overriding
        public override void sleep()
        {
            Console.WriteLine("Cat is sleeping");
        }

    }

    // Excercise
    class Vehicle
    {

        // Constructor
        public Vehicle(string _type)
        {
            type = _type;
        }
        public string type;

        // public bool isAlive;

        // public int price;

        public virtual void Origin()
        {
            Console.WriteLine("No type");
        }

        // Method Overloading
        public void Origin(string ori)
        {
            Console.WriteLine($"Origin: {ori}");
        }
    }

    class Car : Vehicle
    {
        public Car(string _type) : base(_type)
        {
            type = _type;
        }

        // Overriding
        public override void Origin()
        {
            Console.WriteLine("Car Origin");
        }

    }

        class Bike : Vehicle
    {
        public Bike(string _type) : base(_type)
        {
            type = _type;
        }

        // Overriding
        public override void Origin()
        {
            Console.WriteLine("Bike Origin");
        }

    }


}
