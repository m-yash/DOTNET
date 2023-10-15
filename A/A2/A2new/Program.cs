// See https://aka.m    s/new-console-template for more information
namespace Assignment2;


class Program
{
    static void Main(string[] args)
    {
        bool looper = true;



        // List<Customer> customerInfo = new List<Customer>();


        AllReserveration reserverationData = new AllReserveration();
        
        reserverationData.AddReserverationMethod("VCT81", "Yash Mistry", "7879483694", 1, 2, "Child Car Seat ");
        reserverationData.AddReserverationMethod("HJS765", "John Kin", "5478756574", 2, 2, "Child Car Seat ");
        reserverationData.AddReserverationMethod("UYD976", "Sam Dam", "346535765", 1, 2, "Child Car Seat ");


        while (looper)
        {
            

            // for final total
            double total = 0;
            Console.WriteLine("Choose an option below:\n1.Create a reservation\n2.List all reservations\n3.Clear all reservations\n4.Exit the program");
            var path = int.Parse(Console.ReadLine());

            // when 1 entered
            if (path == 1)
            {
                Console.WriteLine("Enter customer information:");

                Console.WriteLine("Customer ID:");
                string CustomerID = Console.ReadLine();

                Console.WriteLine("Name:");
                string CustomerName = Console.ReadLine();

                Console.WriteLine("Phone Number:");
                string CustomerPhoneNo = Console.ReadLine();

                Console.WriteLine("Customer Type:\n0.Regular\n1.Premium\n2.VIP");
                var CustomerType = int.Parse(Console.ReadLine());

                // regular
                if(CustomerType == 0){
                    Console.WriteLine("Choose the number corresponding to the car type the customer wants:\n1.Economy Car Rental - $29.99/day\n2.Standard Car Rental - $49.99/day\n3.Luxury Car Rental - $79.99/day");
                    var CustomerCarTypeRequirement = int.Parse(Console.ReadLine());

                    // economy
                    if(CustomerCarTypeRequirement == 1){
                        total += 29.99;
                    }
                    // standard
                    else if(CustomerCarTypeRequirement == 2){
                        total += 49.99;
                    }
                    // luxury
                    else if(CustomerCarTypeRequirement == 3){
                        total += 79.99;
                    }
                    else{
                        Console.WriteLine("Invalid car type selected");
                    }


                    Console.WriteLine("Does the customer want this additional service? (yes/no)\nGPS Navigation - $9.99/day");
                    var CustomerAdditionalService = Console.ReadLine();
                    if(CustomerAdditionalService == "yes"){
                        total += 9.99;
                        reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, 1, "GPS Navigation");
                        Console.WriteLine("Thank you! The reservation was successful.");
                        Console.WriteLine(total);
                    }
                    else{
                        reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, 1, "No");
                        Console.WriteLine("Thank you! The reservation was successful.");
                        Console.WriteLine(total);

                    }
                }
                // else if(CustomerType == 1){
                //     Console.WriteLine("Choose the number corresponding to the car type the customer wants:\n - Economy Car Rental - $29.99/day\n - Standard Car Rental - $49.99/day\n - Luxury Car Rental - $79.99/day");
                //     var CustomerCarTypeRequirement = int.Parse(Console.ReadLine());
                //     if(CustomerCarTypeRequirement == 1){
                //         total += 29.99;
                //     }
                //     else if(CustomerCarTypeRequirement == 2){
                //         total += 49.99;
                //     }
                //     else if(CustomerCarTypeRequirement == 3){
                //         total += 79.99;
                //     }
                //     else{
                //         Console.WriteLine("Invalid car type selected");
                //     }

                //     Console.WriteLine("Does the customer want this additional service? (yes/no)\nChild Car Seat - $14.99/day ");
                //     var CustomerAdditionalService = Console.ReadLine();
                //     if(CustomerAdditionalService == "yes"){
                //         total += 14.99;
                //     }
                //     else{
                //         Console.WriteLine("Thank you! The reservation was successful.");
                //     }
                // }
                // else if(CustomerType == 2){
                //     Console.WriteLine("Choose the number corresponding to the car type the customer wants:\n - Economy Car Rental - $29.99/day\n - Standard Car Rental - $49.99/day\n - Luxury Car Rental - $79.99/day");
                //     var CustomerCarTypeRequirement = int.Parse(Console.ReadLine());
                //     if(CustomerCarTypeRequirement == 1){
                //         total += 29.99;
                //     }
                //     else if(CustomerCarTypeRequirement == 2){
                //         total += 49.99;
                //     }
                //     else if(CustomerCarTypeRequirement == 3){
                //         total += 49.99;
                //     }
                //     else{
                //         Console.WriteLine("Invalid car type selected");
                //     }

                //     Console.WriteLine("Does the customer want this additional service? (yes/no)\nChauffeur Service - $99.99/day");
                //     var CustomerAdditionalService = Console.ReadLine();
                //     if(CustomerAdditionalService == "yes"){
                //         total += 99.99;
                //     }
                //     else{
                //         Console.WriteLine("Thank you! The reservation was successful.");
                //     }
                    
                // }
                else{
                    Console.WriteLine("Invalid type selected");
                }                      

                


                // customerInfo.Add(new Customer(CustomerID, CustomerName, CustomerPhoneNo,CustomerType, CustomerCarTypeRequirement, CustomerAdditionalService));
               
                // reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerCarTypeRequirement, CustomerAdditionalService);

                // foreach (Customer customerdata in customerInfo)
                // {
                //     Console.WriteLine(customerdata.customerID +" "+ customerdata.customerName +" "+ customerdata.customerPhoneNo);
                // }
            }
            else if(path == 2){
                reserverationData.DisplayReserverationMethod();
            }
            else if(path == 3){
                reserverationData.ClearReserverationMethod();
            }
            else{
                looper = false;
            }


        }
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

    class Reservation
    {

    }
    public class Customer
    {
        public string customerID { get; set; }
        public string customerName { get; set; }
        public string customerPhoneNo { get; set; }
        public int customerType { get; set; }
        public int customerCarTypeRequirement { get; set; }
        public string customerAdditionalService { get; set; }
        public Customer(string id, string name, string phone, int type, int req, string add)
        {
            customerID = id;
            customerName = name;
            customerPhoneNo = phone;
            customerType = type;
            customerCarTypeRequirement = req;
            customerAdditionalService = add;

        }
    }


    // Interface for Clearing Reservation method
    public interface IReservationable
    {
        void ClearReserverationMethod();
        // void AddReserverationMethod(Customer customer);
        void DisplayReserverationMethod();
    }


    // Implementing Interface to define Clear reservation
    public class AllReserveration : IReservationable
    {
        public List<Customer> customerInfo = new List<Customer>();

        // public void AddReserverationMethod(Customer customer){
        //     customerInfo.Add(customer);
        // }
        public void AddReserverationMethod(string CustomerID, string CustomerName, string CustomerPhoneNo, int CustomerType, int CustomerCarTypeRequirement, string CustomerAdditionalService)
        {
            customerInfo.Add(new Customer(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerCarTypeRequirement, CustomerAdditionalService));
        }

        public void ClearReserverationMethod()
        {
            customerInfo.Clear();
            Console.WriteLine("\nAll Reservations Cleared Successfully!");
        }
        public void DisplayReserverationMethod()
        {
            foreach (Customer customerdata in customerInfo)
            {
                Console.WriteLine(customerdata.customerID + " " + customerdata.customerName + " " + customerdata.customerPhoneNo);
            }
        }
    }
}