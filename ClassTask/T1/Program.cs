namespace T1;

class Program
{
    static void Main(string[] args)
    {
        Customer yash = new Customer();
        yash.name = "Yash";

            Customer ash = new Customer();
        ash.name = "Ash";

        Product phone = new Product();
        phone.name = "phone";
        phone.price = 400;

        Product laptop = new Product();
        laptop.name = "laptop";
        laptop.price = 30000;      

        ISupplier standardSup = new StandardSupplier();
        ISupplier premiumSup = new PremiumSupplier();

        Order o1 = new Order();
        o1.customer = yash;
        o1.Addproduct(phone);
        o1.Addproduct(laptop);
        o1.Displayorder();
        o1.supplier = standardSup;
    

        Order o2 = new Order();
        o2.customer = ash;
        o2.Addproduct(phone);
        o2.Addproduct(laptop);
        o2.Displayorder();
        o2.supplier = premiumSup;

       


    }
}

class User{
    public string name;

}

class Customer : User{
    public string address;
    public string email;
    public string phoneno;
}
class Admin : User{
    string priviledges;

}
interface ISupplier{
    string name {get; set;}

    public void shipProduct();
}

class PremiumSupplier : ISupplier{
    public string name {get; set;}
    public void shipProduct(){
        Console.WriteLine("Premium Ship product..");
    }
}

class StandardSupplier : ISupplier{
    public string name {get; set;}
    public void shipProduct(){
        Console.WriteLine("Standard Ship product..");
    }
}

class Product{
    public string name;
    public decimal price;
    public bool isAvailable;
}

class Order{
    public List<Product> orders = new List<Product>();
    public Customer customer;
    public ISupplier supplier;

    public void Addproduct(Product p1){
        orders.Add(p1);
    }

    public void Displayorder(){
        foreach (var item in orders)
        {
            Console.WriteLine($"Product: {item.name} {item.price}");
        }
    }
}