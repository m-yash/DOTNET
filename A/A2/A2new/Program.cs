// See https://aka.m    s/new-console-template for more information
namespace Assignment2;


class Program
{
    static void Main(string[] args)
    {

        ReservationSystemSub r = new ReservationSystemSub();
        r.StartSystem();

        bool looper = true;

        // List<Customer> customerInfo = new List<Customer>();


        AllReserveration reserverationData = new AllReserveration();
        
        // Hardcode data
        reserverationData.AddReserverationMethod("VCT811", "Yash Mistry", "123-456-7890 ", 1, "Standard", "Child Car Seat ", 64.98);
        reserverationData.AddReserverationMethod("HJS765", "John Kin", "547-875-6574", 1, "Economy", "Child Car Seat ",44.98);
        reserverationData.AddReserverationMethod("UYD976", "Sam Dam", "346-535-4765", 1, "Luxury", "Child Car Seat ",94.97);

        List<string> service = new List<string>();
        service.Add("GPS Navigation"); service.Add("Child Car Seat"); service.Add("Chauffeur Service"); service.Add("No Service");

        while (looper)
        {

            //Setting up constant values for customer type
            string[] CustomerTypeConst = {"", "Economy","Standard","Luxury"};

            // Console.WriteLine(CustomerTypeConst[1]);

            // for final total
            double total = 0;

            Console.WriteLine("Choose an option below:\n1.Create a reservation\n2.List all reservations\n3.Clear all reservations\n4.Exit the program");
            var path = int.Parse(Console.ReadLine() ?? string.Empty);
            
            // when 1 entered
            if (path == 1)
            {
                Console.WriteLine("Enter customer information:");

                Console.WriteLine("Customer ID:");
                string CustomerID = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Name:");
                string CustomerName = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Phone Number:");
                string CustomerPhoneNo = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Customer Type:\n0.Regular\n1.Premium\n2.VIP");
                int CustomerType = int.Parse(Console.ReadLine() ?? string.Empty);

                // regular
                if(CustomerType == 0){
                    Console.WriteLine("Choose the number corresponding to the car type the customer wants:\n1.Economy Car Rental - $29.99/day\n2.Standard Car Rental - $49.99/day\n3.Luxury Car Rental - $79.99/day");
                    int CustomerCarTypeRequirement = int.Parse(Console.ReadLine()  ?? string.Empty);

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
                    string CustomerAdditionalService = Console.ReadLine() ?? string.Empty;
                    if(CustomerAdditionalService == "yes"){
                        total += 9.99;
                        reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerTypeConst[CustomerCarTypeRequirement], service[0], total);

                        // showing total while successful reservation
                        Console.WriteLine($"Your Total: ${total}");

                        Console.WriteLine("Thank you! The reservation was successful.");
                    }
                    else{
                        reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerTypeConst[CustomerCarTypeRequirement], service[3], total);
                        Console.WriteLine($"Your Total: ${total}");

                        Console.WriteLine("Thank you! The reservation was successful.");
                        // Console.WriteLine(total);

                    }
                }
                // Premium
                else if(CustomerType == 1){
                    Console.WriteLine("Choose the number corresponding to the car type the customer wants:\n1.Economy Car Rental - $29.99/day\n2.Standard Car Rental - $49.99/day\n3.Luxury Car Rental - $79.99/day");
                    var CustomerCarTypeRequirement = int.Parse(Console.ReadLine() ?? string.Empty);
                    if(CustomerCarTypeRequirement == 1){
                        total += 29.99;
                    }
                    else if(CustomerCarTypeRequirement == 2){
                        total += 49.99;
                    }
                    else if(CustomerCarTypeRequirement == 3){
                        total += 79.99;
                    }
                    else{
                        Console.WriteLine("Invalid car type selected");
                    }

                    Console.WriteLine("Does the customer want this additional service? (yes/no)\nChild Car Seat - $14.99/day ");
                    string CustomerAdditionalService = Console.ReadLine() ?? string.Empty;
                    if(CustomerAdditionalService == "yes"){
                        total += 14.99;
                        reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerTypeConst[CustomerCarTypeRequirement], service[1], total);
                        Console.WriteLine($"Your Total: ${total}");

                        Console.WriteLine("Thank you! The reservation was successful.");                        
                    }
                    else{
                        reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerTypeConst[CustomerCarTypeRequirement], service[3], total);
                        Console.WriteLine($"Your Total: ${total}");
                        Console.WriteLine("Thank you! The reservation was successful.");
                    }
                }
                // VIP
                else if(CustomerType == 2){
                    Console.WriteLine("Choose the number corresponding to the car type the customer wants:\n1.Economy Car Rental - $29.99/day\n2.Standard Car Rental - $49.99/day\n3.Luxury Car Rental - $79.99/day");
                    int CustomerCarTypeRequirement = int.Parse(Console.ReadLine() ?? string.Empty);
                    if(CustomerCarTypeRequirement == 1){
                        total += 29.99;
                    }
                    else if(CustomerCarTypeRequirement == 2){
                        total += 49.99;
                    }
                    else if(CustomerCarTypeRequirement == 3){
                        total += 49.99;
                    }
                    else{
                        Console.WriteLine("Invalid car type selected");
                        break;
                    }

                    Console.WriteLine("Does the customer want this additional service? (yes/no)\nChauffeur Service - $99.99/day");
                    var CustomerAdditionalService = Console.ReadLine();
                    if(CustomerAdditionalService == "yes"){
                        total += 99.99;
                        reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerTypeConst[CustomerCarTypeRequirement], service[2], total);
                        Console.WriteLine($"Your Total: ${total}");
                        Console.WriteLine("Thank you! The reservation was successful.");
                    }
                    else{
                        reserverationData.AddReserverationMethod(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerTypeConst[CustomerCarTypeRequirement], service[3], total);
                        Console.WriteLine($"Your Total: ${total}");
                        Console.WriteLine("Thank you! The reservation was successful.");
                    }
                    
                }
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
            else if(path == 4){
                looper = false;
            }
            else{
                Console.WriteLine("Invalid Input");
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

    // Inheritance (kept it simple)
    class ReservationSystemSup
    {
        public void StartSystem(){
            Console.WriteLine("Reservation System\n");
        }
    }

    class ReservationSystemSub : ReservationSystemSup{

    }


    public class Customer
    {
        public string customerID { get; set; }
        public string customerName { get; set; }
        public string customerPhoneNo { get; set; }
        public int customerType { get; set; }
        public string customerCarTypeRequirement { get; set; }
        public string customerAdditionalService { get; set; }
        public double customerTotal { get; set; }
        public Customer(string id, string name, string phone, int type, string req, string add, double tot)
        {
            customerID = id;
            customerName = name;
            customerPhoneNo = phone;
            customerType = type;
            customerCarTypeRequirement = req;
            customerAdditionalService = add;
            customerTotal = tot;

        }
    }


    // Interface 
    public interface IReservationable
    {
        void ClearReserverationMethod();
        // void AddReserverationMethod(Customer customer);
        void DisplayReserverationMethod();
    }


    // Implementing Interface
    public class AllReserveration : IReservationable
    {
        public List<Customer> customerInfo = new List<Customer>();


        // public void AddReserverationMethod(Customer customer){
        //     customerInfo.Add(customer);
        // }
        public void AddReserverationMethod(string CustomerID, string CustomerName, string CustomerPhoneNo, int CustomerType, string CustomerCarTypeRequirement, string CustomerAdditionalService, double CustomerTotal)
        {
            customerInfo.Add(new Customer(CustomerID, CustomerName, CustomerPhoneNo, CustomerType, CustomerCarTypeRequirement, CustomerAdditionalService, CustomerTotal));
        }

        public void ClearReserverationMethod()
        {
            customerInfo.Clear();
            Console.WriteLine("\nAll Reservations Cleared Successfully!");
        }
        public void DisplayReserverationMethod()
        {
            int cnt = 1;
            foreach (Customer customerdata in customerInfo)
            {

                try{
                    Console.WriteLine($"\nReservation {cnt}: \nCustomer ID: XXX{customerdata.customerID.Substring(3)}\nName: {customerdata.customerName}\nPhone Number: {customerdata.customerPhoneNo}\nCustomer Type: {customerdata.customerType}\nCar Type: {customerdata.customerCarTypeRequirement}\nAdditional Service: {customerdata.customerAdditionalService}\nTotal: ${customerdata.customerTotal}" );
                    cnt++;

                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong! Exit the system and come back\n");
                    break;
                }
                
            }
        }
    }
}