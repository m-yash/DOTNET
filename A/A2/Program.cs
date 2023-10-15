// See https://aka.m    s/new-console-template for more information
namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        bool looper = true;

        // While loop for loyalty error handling
        // while (looper)
        // {
        
        List<Customer> customerInfo = new List<Customer>();

        AllReserveration reserverationData = new AllReserveration();

        customerInfo.Add(new Customer("yash"));
        // Customer customer = new Customer();

        // customer.customerID = "VCT123";
        // customer.customerName = "Yash Mistry";
        // customer.customerPhoneNo = "5482655732";
        // customer.customerType = 1;
        // customer.customerCarTypeRequirement = 1;
        // customer.customerAdditionalService = 2;  

        // customerInfo.Add(customer1);

        // reserverationData.AddReserverationMethod(customer);

        // reserverationData.DisplayReserverationMethod();
        // Console.WriteLine("Choose an option below:\n1.Create a reservation\n2.List all reservations\n3.Clear all reservations\n4.Exit the program");

        // var userOption = Console.ReadLine();
        
        // if(userOption == 1){

        // }
        // if(userOption == 2){
            
        // }
        // if(userOption == 3){
            
        // }
        // if(userOption == 4){
            
        // }
        // else{

        // }                                

        // when 1 entered
        Console.WriteLine("Enter customer information:");

        Console.WriteLine("Customer ID:");
        string CustomerID = Console.ReadLine();

        Console.WriteLine("Name:");
        string CustomerName = Console.ReadLine();

        Console.WriteLine("Phone Number:");
        string CustomerPhoneNo = Console.ReadLine();   

        Console.WriteLine("Customer Type:");
        var CustomerType = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose the number corresponding to the car type the customer wants:");
        var CustomerCarTypeRequirement = int.Parse(Console.ReadLine());        

        Console.WriteLine("Does the customer want this additional service?");
        var CustomerAdditionalService = int.Parse(Console.ReadLine());

        Console.WriteLine("Thank you! The reservation was successful.");

        
        

        // 1 input // user input
        // customer.customerID = CustomerID;
        // customer.customerName = CustomerName;
        // customer.customerPhoneNo = CustomerPhoneNo;
        // customer.customerType = CustomerType;
        // customer.customerCarTypeRequirement = CustomerCarTypeRequirement;
        // customer.customerAdditionalService = CustomerAdditionalService;

        // reserverationData.AddReserverationMethod(customer);
        // reserverationData.AddReserverationMethod(new Customer());


        // reserverationData.DisplayReserverationMethod();

        // When entered 2
        // ClearReserveration clearRes = ClearReserveration();
        // clearRes.ClearReserverationMethod();
    }

    class Reservation{
        
    }
    public class Customer{
        public string customerID { get; set; }
        public string customerName { get; set; }
        public string customerPhoneNo { get; set; }
        public int customerType { get; set; }
        public int customerCarTypeRequirement { get; set; }
        public int customerAdditionalService { get; set; }

    }
    public void Customer(string name){
        customerID = name;
    }

    // Interface for Clearing Reservation method
    public interface IReservationable{
        void ClearReserverationMethod();
        // void AddReserverationMethod(Customer customer);
        void DisplayReserverationMethod();
    }


    // Implementing Interface to define Clear reservation
    public class AllReserveration : IReservationable{
        public List<Customer> customerInfo = new List<Customer>();

        // public void AddReserverationMethod(Customer customer){
        //     customerInfo.Add(customer);
        // }
        public void ClearReserverationMethod(){
            // dictionary.clear()
        }
        public void DisplayReserverationMethod(){
            // foreach (Customer customerdata in customerInfo)
            // {
            //     Console.WriteLine(customerdata.customerName + " " + customerdata.customerID);
            // }
        }
    }
}