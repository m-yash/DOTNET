// Interfaces
// abstract

// // See https://aka.m    s/new-console-template for more information
namespace Week6;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("heallo");
        
        Line l = new Line();
        l.draw();        
        
        Rectangle r = new Rectangle();
        r.draw();
        r.getArea();
        
        List<string> clist = new List<string>();
        clist.Add("red");
        clist.Add("blue");
        clist.Add("green");

        HashSet<string> hlist = new HashSet<string>();
        hlist.Add("red");
        hlist.Add("blue");
        hlist.Add("green");

        Console.WriteLine("\n");    
        foreach (var item in clist)
        {
            Console.Write(item + " ");
        }

        // Console.Write("\n");

        foreach (var item in hlist)
        {
            Console.Write(item + " ");
        }
        // Car c = new Car();
        // c.start();
        // c.stop();

        // Boat b = new Boat();
        // b.start();   
        // b.stop();

        // Bike bb = new Bike();
        // bb.start();
        // bb.stop();
    }

    interface Idrawable{
        void draw();
    }

    interface Ishape{
        void getArea();
    }

    class Line : Idrawable {
        
        public void draw(){
            Console.WriteLine("line -----");
        }
    }

    class Rectangle : Idrawable, Ishape{
        public void draw(){
            Console.WriteLine("Rectangle -----");
        }

        public void getArea(){
            Console.WriteLine("Getting Area -----");
        }
    }

   

    // interface IVechileFunctionality{
    //     void start();
    //     void stop();
    // }

    // class Car : IVechileFunctionality{
    //     public void start(){
    //         Console.WriteLine("Car is starting..");
    //     }

    //     public void stop(){
    //         Console.WriteLine("Car stopped..");
    //     }
    // }

    // class Bike : IVechileFunctionality{
    //     public void start(){
    //         Console.WriteLine("Bike is starting..");
    //     }

    //     public void stop(){
    //         Console.WriteLine("Bike stopped..");
    //     }        
    // }

    // class Boat : IVechileFunctionality{
    //     public void start(){
    //         Console.WriteLine("Boat is starting..");
    //     }

    //     public void stop(){
    //         Console.WriteLine("Boat stopped..");
    //     }        
    // }
}