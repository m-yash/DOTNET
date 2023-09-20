
namespace Calculator;

class Cal{
    int z = 0;

    // Add
    public void add(int x, int y){
        int z = 0;
        int[] values = {x,y};
        foreach (var item in values)
        {
            z += item;
        }
        Console.WriteLine(z);
    }
    // Sub
    public void sub(int x, int y){
    Console.WriteLine(x-y);
    }
    // Mul
    public void mul(int x, int y){
    Console.WriteLine(x*y);
    }
    // Div
    public void div(int x, int y){
    Console.WriteLine(x/y);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Group Name: T5* \n");
        Console.WriteLine("*Calculate It* \n");

        Console.WriteLine("Enter number 1");
        int a = int.Parse(Console.ReadLine());
        // string x1 = x.ToString();
        Console.WriteLine("Enter number 2");
        int b = int.Parse(Console.ReadLine());
        // string y1 = y.ToString();

        Cal c = new Cal();
         
        try{    
            // string Manipulation
            string x1 = a.ToString();
            string y1 = b.ToString();
            
            if(char.IsDigit(x1,0) && char.IsDigit(y1,0)){
                Console.WriteLine("\nYour Inputs are valid!");
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("Enter 1.Addition 2.Subtraction 3.Multiplication 4.Division");
            int z = int.Parse(Console.ReadLine());

            if(z == 1){
                c.add(a,b);
            }
            else if(z == 2){
                c.sub(a,b);
            }
            else if(z == 3){
                c.mul(a,b);
            }
            else {
                c.div(a,b);
            }
   
        }
        catch(Exception e){
            Console.WriteLine("Invalid input");
        }
  
    }
}