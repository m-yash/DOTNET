using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;


namespace Project.Pages;

public class ReservationModel : PageModel
{
    private readonly ILogger<ReservationModel> _logger;
    
    public Reservation reserve = new Reservation();
    // public Reservation? reserve;

    // List<Reservation> reservationList = new List<Reservation>();

    // public List<Car> Cars { get; set; }a  = new List<Car>();
    public string reservationFile = "reservations.json";
    private CarData cardata = new CarData();
    // public CarDetails cardetails = new CarDetails();
    public List<CarDetails> cars = new List<CarDetails>();
    public ReservationModel(ILogger<ReservationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // Fetching data from availablecars.json
        cars = cardata.GetCarDataJSON();

    }

    public IActionResult OnPost(Reservation reserve)
    {
        // Saving data to reversations.josn
        
        // reservationList.Add(new Reservation(CarName, UserName, UserMobileNumber, UserReservationDateTime));

        // List<Reservation> tODOItems = GetTODOItemsJSON();
        // tODOItem.ID = tODOItems.Count + 1;
        // tODOItems.Add(tODOItem);

        // string json = JsonConvert.SerializeObject(reservation, Formatting.Indented);
        // File.WriteAllText(reservationFile, json);
        // cardata.SaveCarDataJSON(reserve);
        Console.WriteLine(reserve.ToString());

        // Page Redirection
        return RedirectToPage("Confirmation", reserve);



    }
}


// Class
public class Reservation{
    // public string ID {get; set;} = string.Empty;
    public string CarName {get; set;} = string.Empty;
    public string UserName {get; set;} = string.Empty;
    public string UserMobileNumber {get; set;} = string.Empty;
    public string UserReservationDateTime {get; set;} = string.Empty;
    
    public Reservation(string CarName, string UserName, string UserMobileNumber, string UserReservationDateTime)
    {
        // this.ID = id;
        this.CarName = CarName;
        this.UserName = UserName;
        this.UserMobileNumber = UserMobileNumber;
        this.UserReservationDateTime = UserReservationDateTime;
    }
    public Reservation()
    {
        // Add any default initialization if needed
    }
    public override string ToString(){
        return $"CarName: {CarName} UserName: {UserName}, Mobile Number: {UserMobileNumber}, Reservation Date: {UserReservationDateTime}";
    }
}
public class Car
    {
        public string Model { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }