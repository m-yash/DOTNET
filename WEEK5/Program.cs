// Inheritance
// Method Overloading/ Overriding
// Polymorphism
// Composition
// Up Casting
// List
// ArrayList
// LinkedList

namespace Week5;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("ZOOOOOOOOOOO \n");
        // Console.WriteLine("VECCHILE \n");


        // Console.WriteLine("Parent Class");
        // Animal a = new Animal("animal", false, 800);

        // Up Casting
        // Animal a = new Cat("cat", false, 800);
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
        // Console.WriteLine(c.ToString());
        // Console.WriteLine($"{c.species} {c.isAlive} {c.price}");
// ------------------------------------------------------------------------------
        // Console.WriteLine("Vechile");
        // Vehicle v = new Vehicle("Unknown");
        // v.Origin();

        // Console.WriteLine("\nCar");
        // Car carr = new Car("Sport");
        // carr.Origin();
        // carr.Origin("Brazil");

        // Console.WriteLine("Type: " + carr.type);

        // Console.WriteLine("\nBike");
        // Bike bi = new Bike("Casual");
        // bi.Origin();
        // bi.Origin("Africa");

        // Console.WriteLine("Type: " + bi.type);
// ------------------------------------------------------------------------------

        // Student s = new Student();
        // s.display();
// ------------------------------------------------------------------------------

        // List
        // List<Student> StudentList = new List<Student>();

        // Student s1 = new Student();
        // Student s2 = new Student();

        // StudentList.Add(s1);
        // StudentList.Add(s2);


        // List<int> l = new List<int>();
        // l.Add(1); l.Add(2); l.Add(3); l.Add(4);
        // Console.WriteLine($"Element at 0: {l.ElementAt(0)}");
        // Console.WriteLine($"Element Count: {l.Count()}");
        // l.Remove(1);
        // Console.WriteLine($"Element Count: {l.Count()} after removal");

        // foreach (var item in l)
        // {
        //     Console.WriteLine(item);
        // }
        
        // foreach (var item in StudentList)
        // {
        //     Console.WriteLine(item);
        // }

        // ArrayList
        // ArrayList al = new ArrayList();
        // al.Add("string");
        // al.Add(s1);
        // al.Add(1);

        // foreach (var item in al)
        // {
        //     Console.WriteLine(item);
        // }

        // Linked List
        // LinkedList<string> ll = new LinkedList<string>();
        // ll.AddLast("a");
        // ll.AddLast("b");

        // foreach (var item in ll)
        // {
        //     Console.WriteLine("Linkedlist value: " +item);
        // }       

        // Hashset
        // HashSet<string> colorSet = new HashSet<string>();
        // colorSet.Add("red");
        // colorSet.Add("green");
        // Console.WriteLine("Hashset count: " +colorSet.Count());

        // foreach (var item in colorSet)
        // {
        //     Console.WriteLine("Hashset value: " +item);
        // }      

        // Dictionary
        // Dictionary<string,int> student = new Dictionary<string,int>();
        // student.Add("yash", 1);
        // student.Add("hsay", 2);
        
        // foreach (var item in student)
        // {
        //     Console.WriteLine("Dictionary values: "+item.Key+ " " +item.Value);
        // }      
        // Console.WriteLine("dictionary yash value:  " +student["yash"]);




        // Excerise

        
        



    }

    class Passenger{
        public string name;
        public int baggage;

        Dictionary<string,int> pass = new Dictionary<string,int>();

        public void add(){
            bool looper = true;
        
            while(looper){
                Console.WriteLine("\nTicketing System \n1.Add Passenger information\n2.Print Passenger\n0.Exit\n");
                
                int flow = int.Parse(Console.ReadLine());

                if (flow == 0){
                    looper = false;
                }
                else if (flow == 1){
                    Console.WriteLine("Enter Passenger Name");
                    var passName = Console.ReadLine();

                    Console.WriteLine("Enter Number of bags");
                    int passBag = int.Parse(Console.ReadLine());

                    
                    pass.Add(passName, passBag);
                }
                else if(flow == 2){
                    foreach (var item in pass)
                    {
                        Console.WriteLine("\nPassenger Name: "+item.Key+ "\nPassenger total bags: " +item.Value);
                    }   
                }
            }

        }


    }
    class Baggage : Passenger{


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
            if(isAlive){
                Console.WriteLine("Animal is breathing (good to sell)");
            }
            
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

        // public AnimalName animalName;
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

        public override string ToString(){
            return $"ToString Overloaded: {species} {isAlive}";
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

    class Student
    {
        public Name stuName;
        public Address stuAddress;

        // public void display(){
        //     Console.WriteLine($"{stuName}");
        // }
    }
    class Faculty
    {
        public Name FacName;
        public Address FacAddress;
    }

    class Name
    {
        string name;
    }
    class Address
    {
        string address;
    }


}
